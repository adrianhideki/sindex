using DocumentFormat.OpenXml.Drawing.Charts;
using MetroFramework.Components;
using sindex.repository;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmMissingIndexes : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Database Name", "Média de Impacto", "Última Leitura", "Tabela", "Script de Criação" };
        bool[] gridVisible = { true, true, true, true, true };

        public frmMissingIndexes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            this.main = main;
            this.conf = conf;

            InitializeComponent();

            try
            {
                this.metroStyleManager.Theme = metroStyleManager.Theme;
                this.metroStyleManager.Style = metroStyleManager.Style;

                cbxFiltro.SelectedIndex = 0;
                GetDataGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResizeGrid(DataGridView grd)
        {

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                grd.Columns[i].HeaderText = gridColName[i];
                grd.Columns[i].Visible = gridVisible[i];
            }

            int widthMedia = (grdIndexes.Width / (grdIndexes.Columns.GetColumnCount(DataGridViewElementStates.Visible))) - 10;

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                if (grd.Columns[i].Visible)
                  grd.Columns[i].Width = widthMedia;
            }
        }

        private void GetDataGrid()
        {

            string database = "";
            string table = "";

            if (cbxFiltro.Text == "Database")
            {
                database = txtFiltro.Text;
            } 
            else if (cbxFiltro.Text == "Table")
            {
                table = txtFiltro.Text;
            }

            System.Data.DataTable dt = dbIndexes.GetMissingIndexes(main.GetCredentials(), main.databaseSindex, database, table);

            grdIndexes.DataSource = dt;
            grdIndexes.Refresh();
            ResizeGrid(grdIndexes);
        }

        private void grdIndexes_Resize(object sender, EventArgs e)
        {
            ResizeGrid(grdIndexes);
        }
    }
}
