using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Assignment_Module_7
{
    class MultiSDIApp : WindowsFormsApplicationBase
    {
        private static MultiSDIApp app;


        internal static MultiSDIApp Application
        {
            get
            {
                if(app == null)
                {
                    app = new MultiSDIApp();
                }
                return app;
            }
        }

        public MultiSDIApp()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = CreateTopLevelWindow(this.CommandLineArgs);
        }

        //private void CreateTopLevelWindow(ReadOnlyCollection<string> args)
        private MainForm CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            String fileName = null;

            if(args.Count > 0)
            {
                fileName = args[0];
            }

            //need to do the long call to the static funtion cuz MainForm is a property for MultiSDIApp
            return Text_Assignment_Module_7.MainForm.CreateTopLevelWindow(fileName, false); 
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            CreateTopLevelWindow(eventArgs.CommandLine);
        }

        public void AddTopLevelForm(Form form)
        {
            form.FormClosed += Form_FormClosed;
            form.Activated += Form_Activated;
            if (this.OpenForms.Count == 1)
            {
                this.MainForm = form;
            }
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;

            if(form == this.MainForm && this.OpenForms.Count > 0)
            {
                this.MainForm = (Form)this.OpenForms[0];
            }

            form.FormClosed -= Form_FormClosed;
            form.Activated -= Form_Activated;
        }

        void Form_Activated(Object sender, EventArgs e)
        {
            this.MainForm = (Form)sender;
        }

        //void windowMenu_DropDownOpening(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem menu = sender as ToolStripMenuItem;
        //    menu.DropDownItems.Clear();
        //    foreach (Form form in this.OpenForms)
        //    {
        //        ToolStripMenuItem item = new ToolStripMenuItem(form.Text);
        //        item.Tag = form;
        //        item.Click += item_Click;
        //        item.Checked = form == Form.ActiveForm;
        //        menu.DropDownItems.Add(item);
        //    }
        //}

        //public void AddWindowMenu(ToolStripMenuItem windowMenu)
        //{
        //    windowMenu.DropDownOpening += windowMenu_DropDownOpening;
        //}

        //void item_Click(object sender, EventArgs e)
        //{
        //    ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        //}
    }
}
