﻿using AdminView.Presenter;
using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminView
{
    public partial class ListMenu : Form
    {
        public ListMenu()
        {
            InitializeComponent();
            new ListMenuPresenter(this);
        }
        
        public MenuStrip MenuStrip { get => menuStrip; set => menuStrip = value; }
        public bool IsUser { get; set; } = false;
        public DataGridView List { get { return criminalsList; } set { criminalsList = value; } }
        public DataGridView GangList { get => gangGridView; set => gangGridView = value; }
        public DataGridView ArchiveList { get { return archiveList; } set { archiveList = value; } }
        public event EventHandler LoadEvent = null;
        private void ListMenu_Load(object sender, EventArgs e)
        {
           LoadEvent(sender, e);
            OnUserCahngeEvent(IsUser);
        }
        public delegate void MyDel(bool b);
        public event MyDel OnUserCahngeEvent = null;
        public BindingSource ABS { get => archiveBindingSource; set => archiveBindingSource = value; }
        public BindingSource GBS { get => criminalGangsBindingSource; set => criminalGangsBindingSource = value; }
        public BindingSource CBS { get => criminalsBindingSource; set => criminalsBindingSource = value; }
        public event EventHandler AddCriminalEvent = null;
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCriminalEvent(sender, e);
            SaveEvent(sender, e);
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ci = new CriminalInfo((Criminal)List.CurrentRow.DataBoundItem, IsUser);
            if(ci.ShowDialog() == DialogResult.OK)
            {
                SaveEvent(sender, e);
            }
            
        }

        
        public event EventHandler SaveEvent;

        
        public event EventHandler MoveToArchiveEvent;

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveToArchiveEvent(sender, e);
        }
        public event EventHandler MoveToListevent = null;
        private void moveToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveToListevent(sender, e);
        }

        public event KeyEventHandler AutorizationEvent;

        private void ListMenu_KeyDown(object sender, KeyEventArgs e)
        {
            AutorizationEvent(sender, e);
            OnUserCahngeEvent(IsUser);
        }
        public event EventHandler AddGangEvent;
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddGangEvent(sender, e);
            SaveEvent(sender, e);
        }
    }
}
