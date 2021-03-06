﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace AddPropertiesForWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application oWord;
            Word._Document oDoc;
            object MissingValue = Missing.Value;
            object oDocCustomProps;

            oWord = new Word.Application();
            oWord.Visible = false;

            object file=null;
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
               file = dialog.FileName;
            oDoc = oWord.Documents.Open(
            ref file, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

            oDocCustomProps = oDoc.CustomDocumentProperties;
            Type typeDocCustomProps = oDocCustomProps.GetType();
  
            string strIndex = "Secret Flag";
            string strValue = "秘密";
            object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

            typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                       BindingFlags.InvokeMethod, null,
                                       oDocCustomProps, oArgs);

            Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue);
            parag.Range.InsertParagraph();

            oDoc.Password = "123456";

            oDoc.SaveAs(ref file, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

            oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

            MessageBox.Show("设置秘密成功！");

           // oWord.Quit(ref MissingValue, ref MissingValue, ref MissingValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Word.Application oWord;
            Word._Document oDoc;
            object MissingValue = Missing.Value;
            object oDocCustomProps;

            oWord = new Word.Application();
            oWord.Visible = false;

            object file = null;
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                file = dialog.FileName;
            oDoc = oWord.Documents.Open(
            ref file, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

            oDocCustomProps = oDoc.CustomDocumentProperties;
            Type typeDocCustomProps = oDocCustomProps.GetType();

            string strIndex = "Secret Flag";
            string strValue = "机密";
            object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

            typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                       BindingFlags.InvokeMethod, null,
                                       oDocCustomProps, oArgs);

            Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue);
            parag.Range.InsertParagraph();

            oDoc.SaveAs(ref file, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

            oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

            MessageBox.Show("设置机密成功！");

            //oWord.Quit(ref MissingValue, ref MissingValue, ref MissingValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Word.Application oWord;
            Word._Document oDoc;
            object MissingValue = Missing.Value;
            object visibleflase = false;
            object oDocCustomProps;

            oWord = new Word.Application();
            oWord.Visible = false;

            object file = null;
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                file = dialog.FileName;
            oDoc = oWord.Documents.Open(
            ref file, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue,
            ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

            oDocCustomProps = oDoc.CustomDocumentProperties;
            Type typeDocCustomProps = oDocCustomProps.GetType();

            string strIndex = "Secret Flag";
            string strValue = "绝密";
            object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

            typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                       BindingFlags.InvokeMethod, null,
                                       oDocCustomProps, oArgs);

        
            Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue); 
            parag.Range.InsertParagraph();

            oDoc.SaveAs(ref file, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);
            
            oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

            MessageBox.Show("设置绝密成功！");

            //oWord.Quit(ref MissingValue, ref MissingValue, ref MissingValue);
        }
    }
}
