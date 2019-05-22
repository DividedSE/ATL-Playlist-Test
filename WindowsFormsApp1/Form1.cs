using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATL.Playlist;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            loc = textBox1.Text;
            listBox2.Items.Clear();
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                {
                    if (comboBox4.SelectedIndex == -1)
                    {
                        asx1 = ".asx";
                    }
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                        {
                            switch (comboBox2.SelectedIndex)
                            {
                                case 0:
                                {
                                    var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM"+asx1, PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_BOM);
                                    IList<string> pathsToWrite = new List<string>();
                                    foreach (var item in listBox1.Items)
                                    {
                                        pathsToWrite.Add(item.ToString());
                                    }
                                    pls.FilePaths = pathsToWrite;
                                    var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM" + asx1);
                                    foreach (var s in theReader.FilePaths)
                                    {
                                        listBox2.Items.Add(s);
                                    }

                                    break;
                                }

                                case 1:
                                {
                                    var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM" + asx1, PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_NO_BOM);
                                    IList<string> pathsToWrite = new List<string>();
                                    foreach (var item in listBox1.Items)
                                    {
                                        pathsToWrite.Add(item.ToString());
                                    }
                                    pls.FilePaths = pathsToWrite;
                                    var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM" + asx1);
                                    foreach (var s in theReader.FilePaths)
                                    {
                                        listBox2.Items.Add(s);
                                    }

                                    break;

                                }
                            }
                            
                            break;
                        }
                        case 1:
                        {
                            var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"MSURI"+asx1,PlaylistFormat.LocationFormatting.MS_URI);
                            IList<string> pathsToWrite = new List<string>();
                            foreach (var item in listBox1.Items)
                            {
                                pathsToWrite.Add(item.ToString());
                            }
                            pls.FilePaths = pathsToWrite;
                            var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"MSURI" + asx1);
                            foreach (var s in theReader.FilePaths)
                            {
                                listBox2.Items.Add(s);
                            }
                            break;
                        }
                        case 2:
                        {
                            var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI"+asx1,PlaylistFormat.LocationFormatting.RFC_URI);
                            IList<string> pathsToWrite = new List<string>();
                            foreach (var item in listBox1.Items)
                            {
                                pathsToWrite.Add(item.ToString());
                            }
                            pls.FilePaths = pathsToWrite;
                            var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI" + asx1);
                            foreach (var s in theReader.FilePaths)
                            {
                                listBox2.Items.Add(s);
                            }
                            break;
                        }
                    }
                    return;
                }
                case 1:
                {
                    listBox2.Items.Clear();
                    switch (comboBox1.SelectedIndex)
                    {
                        case 2:
                        {
                            var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI.b4s", PlaylistFormat.LocationFormatting.RFC_URI,PlaylistFormat.FileEncoding.UTF8_NO_BOM);
                            IList<string> pathsToWrite = new List<string>();
                            foreach (var item in listBox1.Items)
                            {
                                pathsToWrite.Add(item.ToString());
                            }
                            pls.FilePaths = pathsToWrite;
                            var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI.b4s");
                            foreach (var s in theReader.FilePaths)
                            {
                                listBox2.Items.Add(s);
                            }
                            break;
                                }

                        case 3:
                        {
                            var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"WinampURI.b4s", PlaylistFormat.LocationFormatting.Winamp_URI);
                            IList<string> pathsToWrite = new List<string>();
                            foreach (var item in listBox1.Items)
                            {
                                pathsToWrite.Add(item.ToString());
                            }
                            pls.FilePaths = pathsToWrite;
                            var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"WinampURI.b4s");
                            foreach (var s in theReader.FilePaths)
                            {
                                listBox2.Items.Add(s);
                            }
                            break;
                                }
                    }


                    return;
                }
                case 2:
                {
                    listBox2.Items.Clear();
                        if (comboBox1.SelectedIndex == 0)
                        {
                            switch (comboBox2.SelectedIndex)
                            {
                                case 0:
                                    {
                                        var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.m3u",PlaylistFormat.LocationFormatting.FilePath,PlaylistFormat.FileEncoding.UTF8_BOM);
                                        IList<string> pathsToWrite = new List<string>();
                                        foreach (var item in listBox1.Items)
                                        {
                                            pathsToWrite.Add(item.ToString());
                                        }
                                        pls.FilePaths = pathsToWrite;
                                        var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.m3u");
                                        foreach (var s in theReader.FilePaths)
                                        {
                                            listBox2.Items.Add(s);
                                        }

                                        break;
                                    }

                                case 1:
                                    {
                                        var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.m3u", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_NO_BOM);
                                        IList<string> pathsToWrite = new List<string>();
                                        foreach (var item in listBox1.Items)
                                        {
                                            pathsToWrite.Add(item.ToString());
                                        }
                                        pls.FilePaths = pathsToWrite;
                                        var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.m3u");
                                        foreach (var s in theReader.FilePaths)
                                        {
                                            listBox2.Items.Add(s);
                                        }

                                        break;

                                    }
                            }

                            break;
                        }
                        return;
                        
                }
                case 3:
                {
                    listBox2.Items.Clear();
                        switch (comboBox2.SelectedIndex)
                        {
                            case 0:
                                {
                                    var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.m3u8", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_BOM);
                                    IList<string> pathsToWrite = new List<string>();
                                    foreach (var item in listBox1.Items)
                                    {
                                        pathsToWrite.Add(item.ToString());
                                    }
                                    pls.FilePaths = pathsToWrite;
                                    var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.m3u8");
                                    foreach (var s in theReader.FilePaths)
                                    {
                                        listBox2.Items.Add(s);
                                    }

                                    break;
                                }

                            case 1:
                                {
                                    var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.m3u8", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_NO_BOM);
                                    IList<string> pathsToWrite = new List<string>();
                                    foreach (var item in listBox1.Items)
                                    {
                                        pathsToWrite.Add(item.ToString());
                                    }
                                    pls.FilePaths = pathsToWrite;
                                    var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.m3u8");
                                    foreach (var s in theReader.FilePaths)
                                    {
                                        listBox2.Items.Add(s);
                                    }

                                    break;

                                }
                        }
                        return;
                       
                }
                case 4:
                {
                    listBox2.Items.Clear();
                    if (comboBox1.SelectedIndex == 0)
                    {
                            switch (comboBox2.SelectedIndex)
                            {
                                case 0:
                                    {
                                        var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.pls", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_BOM);
                                        IList<string> pathsToWrite = new List<string>();
                                        foreach (var item in listBox1.Items)
                                        {
                                            pathsToWrite.Add(item.ToString());
                                        }
                                        pls.FilePaths = pathsToWrite;
                                        var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.pls");
                                        foreach (var s in theReader.FilePaths)
                                        {
                                            listBox2.Items.Add(s);
                                        }

                                        break;
                                    }

                                case 1:
                                    {
                                        var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.pls", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_NO_BOM);
                                        IList<string> pathsToWrite = new List<string>();
                                        foreach (var item in listBox1.Items)
                                        {
                                            pathsToWrite.Add(item.ToString());
                                        }
                                        pls.FilePaths = pathsToWrite;
                                        var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.pls");
                                        foreach (var s in theReader.FilePaths)
                                        {
                                            listBox2.Items.Add(s);
                                        }

                                        break;

                                    }
                            }
                            break;
                    }
                    return;
                }
                case 5:
                {

                    listBox2.Items.Clear();
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                        {
                                    switch (comboBox2.SelectedIndex)
                                    {
                                        case 0:
                                            {
                                                var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.xspf", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_BOM);
                                                IList<string> pathsToWrite = new List<string>();
                                                foreach (var item in listBox1.Items)
                                                {
                                                    pathsToWrite.Add(item.ToString());
                                                }
                                                pls.FilePaths = pathsToWrite;
                                                var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFBOM.xspf");
                                                foreach (var s in theReader.FilePaths)
                                                {
                                                    listBox2.Items.Add(s);
                                                }

                                                break;
                                            }

                                        case 1:
                                            {
                                                var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.xspf", PlaylistFormat.LocationFormatting.FilePath, PlaylistFormat.FileEncoding.UTF8_NO_BOM);
                                                IList<string> pathsToWrite = new List<string>();
                                                foreach (var item in listBox1.Items)
                                                {
                                                    pathsToWrite.Add(item.ToString());
                                                }
                                                pls.FilePaths = pathsToWrite;
                                                var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"FilepathUTFNoBOM.xspf");
                                                foreach (var s in theReader.FilePaths)
                                                {
                                                    listBox2.Items.Add(s);
                                                }

                                                break;

                                            }
                                    }
                                    break;
                                }

                        case 2:
                        {
                            var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI.xspf", PlaylistFormat.LocationFormatting.RFC_URI);
                            IList<string> pathsToWrite = new List<string>();
                            foreach (var item in listBox1.Items)
                            {
                                pathsToWrite.Add(item.ToString());
                            }
                            pls.FilePaths = pathsToWrite;
                            var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI.xspf");
                            foreach (var s in theReader.FilePaths)
                            {
                                listBox2.Items.Add(s);
                            }
                            break;
                                }
                    }


                        return;
                }

                case 6:
                {
                    if (comboBox5.SelectedIndex == -1)
                    {
                        smil1 = ".wpl";
                    }
                    var pls = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI"+smil1,PlaylistFormat.LocationFormatting.RFC_URI);
                    IList<string> pathsToWrite = new List<string>();
                    foreach (var item in listBox1.Items)
                    {
                        pathsToWrite.Add(item.ToString());
                    }
                    pls.FilePaths = pathsToWrite;
                    var theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(loc+"RFCURI"+ smil1);
                    foreach (var s in theReader.FilePaths)
                    {
                        listBox2.Items.Add(s);
                    }

                    break;

                    }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox3.SelectedIndex)
            {
                case 0:
                {
                    comboBox4.Enabled = true;
                    comboBox5.Enabled = false;
                    break;
                }

                case 6:
                {
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = true;
                    break;
                }

                default:
                {
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    break;
                }
            }
        }

        public string asx1;
        public string smil1;
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                {
                    asx1 = ".asx";break;
                }
                case 1:
                {
                    asx1 = ".wax"; break;
                }
                case 2:
                {
                    asx1 = ".wvx"; break;
                }
            }
        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                {
                    smil1 = ".smil"; break;
                }
                case 1:
                {
                    smil1 = ".smi"; break;
                }
                case 2:
                {
                    smil1 = ".wpl"; break;
                }
                case 3:
                {
                    smil1 = ".zpl"; break;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var songPaths = openFileDialog1.FileNames;
                for (var i = 0; i <= songPaths.Length - 1; i++)
                {
                    listBox1.Items.Add(songPaths[i]);
                }
            }
        }

        public string loc;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            loc = textBox1.Text;
        }
    }
}
