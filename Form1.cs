using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace TranslateTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "请选择您要执行翻译的文件目录";
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    txtPath.Text = selectedPath;
                }
            }
        }


        private void btnTransferToSimplified_Click(object sender, EventArgs e)
        {
            TransferLanguage(VbStrConv.SimplifiedChinese);
        }

        private void btnTransferToTraditional_Click(object sender, EventArgs e)
        {
            TransferLanguage(VbStrConv.TraditionalChinese);
        }

        private void TransferLanguage(VbStrConv vbStrConv)
        {
            string folderPath = txtPath.Text;
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("请选择文件目录");
                return;
            }
            string filter = "*";
            List<string> types = new List<string>();
            foreach (var item in ckTypeList.CheckedItems)
            {
                types.Add(item.ToString());
            }
            if (types.Count > 0)
                filter = string.Join("|", types.ToArray());
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            var list = directoryInfo.GetFiles("*", SearchOption.AllDirectories).Where(m => types.Contains(m.Extension.ToLower())).ToList();
            int i = 1;
            list.ForEach(m => {
                string path = m.FullName;
                var data = File.ReadAllText(path);
                string newData = Strings.StrConv(data, vbStrConv, 1033);
                File.WriteAllText(path, newData);
                listMessage.Items.Add($"[{i}/{list.Count}]{vbStrConv.ToString()}{path}");
                i++;
            });
        }

        private void txtPath_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> typeList = new List<string>() {
                ".cs",".txt",".cshtml",".html",".htm",".xml",".js",".ts",".css",".scss",".vue",".json",".config",".md",".aspx"};
            typeList.ForEach(m =>
            {
                ckTypeList.Items.Add(m, true);
            });
        }
    }
}
