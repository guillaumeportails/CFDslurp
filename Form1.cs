using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Diagnostics;

namespace CFDslurp
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent ();

            webBrowser.AllowNavigation = true;
            webBrowser.AllowWebBrowserDrop = false;
            mIGC.Clear ();
        }

        enum State
        {
            Nil,
            ScanningGPSLinks,
            ScanningIGCLink
        };

        State mState = State.Nil;
        int mPage = 0;

        // Liste de pages ou trouver des IGC : les HREF "gps"
        List<string> mList = new List<string> ();

        //
        HashSet<string> mIGC = new HashSet<string> ();

        // Enumeration des pages a explorer (passer a Next a chaque PageLoadCompleted)
        IEnumerator<string> mEnum = null;

        // GOTO one page
        private void button2_Click (object sender, EventArgs e)
        {
            mState = State.ScanningGPSLinks;
            mPage = 0;
            mList.Clear ();
            webBrowser.Navigate (textBoxURL.Text + mPage);
        }

        // ADD IGC : scanne les liens "gps" de la page en cours
        private void button1_Click (object sender, EventArgs e)
        {
            mState = State.ScanningIGCLink;
            Trace.WriteLine ("Searching IGC");
            mEnum = mList.GetEnumerator ();
            if (mEnum.MoveNext ()) webBrowser.Navigate (mEnum.Current);
        }

        // Cherche les liens HREF "gps" dans le document et ajoute ces pages a mList
        // Chacune d'elles contient en effet un HREF vers un IGC
        private void ScanGPSLinks (HtmlDocument dom)
        {
            foreach (HtmlElement lnk in dom.Links)
            {
                //Trace.WriteLine ("Name=" + lnk.Name + " Tag=" + lnk.TagName + " Id="+lnk.Id + " Out=" + lnk.OuterText);
                if (lnk.OuterText == "gps")
                {
                    //Trace.WriteLine ("***  " + lnk.GetAttribute ("HREF"));
                    mList.Add (lnk.GetAttribute ("HREF"));
                }
            }
        }

        // Cherche le lien HREF "IGC" dans le document et ajoute cette pages a mIGC
        private void ScanIGCLink (HtmlDocument dom)
        {
            // Find the link to the IGC file
            foreach (HtmlElement lnk in dom.Links)
            {
                //Trace.WriteLine ("Name=" + lnk.Name + " Tag=" + lnk.TagName + " Id=" + lnk.Id + " Out=" + lnk.OuterText);
                if ((lnk.OuterText != null) && (lnk.OuterText.EndsWith (".igc")))
                {
                    //Trace.WriteLine ("***  " + lnk.GetAttribute ("HREF"));
                    mIGC.Add (lnk.GetAttribute ("HREF"));
                }
            }
        }

        // Le browser a fini de charger la page en cours
        private void webBrowser_DocumentCompleted (object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Stop ();                         // Arrete les scripts inutiles !
            HtmlDocument dom = webBrowser.Document;
            Trace.WriteLine ("Gone to " + dom.Url);

            switch (mState)
            {
                case State.Nil :
                    break;

                case State.ScanningGPSLinks:
                    ScanGPSLinks (dom);

                    // Navigate to the next page
                    ++mPage;
                    webBrowser.Navigate (textBoxURL.Text + mPage);
                    break;

                case State.ScanningIGCLink:
                    if (mEnum == null) return;
                    ScanIGCLink (dom);

                    // Navigate to the next page
                    if (!mEnum.MoveNext ())
                    {
                        Trace.WriteLine ("Listing DONE");
                        mEnum = null;
                    }
                    else
                        webBrowser.Navigate (mEnum.Current);
                break;
            }
        }

        // GET IGC
        private void button3_Click (object sender, EventArgs e)
        {
            mEnum = null;
            mState = State.Nil;
            string Home = "C:/GIS/IGC/";

            Directory.CreateDirectory (Home);

            WebClient wc = new WebClient ();
            foreach (string igc in mIGC)
            {
                Trace.WriteLine ("Downloading " + Path.GetFileName (igc));
                wc.DownloadFile (igc, Home + "/" + Path.GetFileName (igc));
            }
            Trace.WriteLine ("Downloading DONE");
        }

        private void button4_Click (object sender, EventArgs e)
        {
            mIGC.Clear ();
        }

    }
}
