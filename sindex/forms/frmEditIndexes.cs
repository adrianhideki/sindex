using MetroFramework.Components;
using sindex.model;
using sindex.repository;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmEditIndexes : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Database Name", "Table Name", "Índice", "Create Date", "Script Drop", "Script Create" };
        bool[] gridVisible = { true, true, true, true, true, true };
        int scriptColumn = 4;
        int scriptColumn2 = 5;

        DataTable dtFragmentedIndexes;

        public frmEditIndexes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
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
                SetTheme();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetTheme()
        {
            Color bgColor = Color.FromArgb(17, 17, 17);
            Color frColor = Color.FromArgb(119, 119, 119);

            txtScriptDrop.ForeColor = frColor;
            txtScriptDrop.BackColor = bgColor;

            txtScriptCreate.ForeColor = frColor;
            txtScriptCreate.BackColor = bgColor;
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
            if (grd.Rows.Count <= 0) return;

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
            string index = "";

            if (cbxFiltro.Text == "Database")
            {
                database = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Table")
            {
                table = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Index")
            {
                index = txtFiltro.Text;
            }

            dtFragmentedIndexes = dbIndex.GetScriptIndexes(main.GetCredentials(), main.databaseSindex, database, table, index);

            mnuIndexes.Enabled = !(dtFragmentedIndexes.Rows.Count <= 0);

            grdIndexes.DataSource = dtFragmentedIndexes;
            grdIndexes.Refresh();
            ResizeGrid(grdIndexes);

            lblLinhas.Text = dtFragmentedIndexes.Rows.Count.ToString() + " linhas.";
        }
        private void grdIndexes_Resize(object sender, EventArgs e)
        {
            ResizeGrid(grdIndexes);
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                grdIndexes.Theme = MetroFramework.MetroThemeStyle.Light;
                grdIndexes.Style = MetroFramework.MetroColorStyle.Silver;

                PrintSindex.PrintGrid("Indexes", "", "", grdIndexes);

                grdIndexes.Theme = MetroFramework.MetroThemeStyle.Default;
                grdIndexes.Style = MetroFramework.MetroColorStyle.Default;
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSindex.PrintExcel(dtFragmentedIndexes, "Indexes");
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grdIndexes_SelectionChanged(object sender, EventArgs e)
        {
            if (grdIndexes.SelectedRows.Count > 0)
            {
                txtScriptDrop.Clear();
                txtScriptCreate.Clear();

                for (int i = 0; i < grdIndexes.SelectedRows.Count; i++)
                {
                    txtScriptDrop.Text += grdIndexes.SelectedRows[i].Cells[scriptColumn].Value.ToString() + "\n";
                    txtScriptCreate.Text += grdIndexes.SelectedRows[i].Cells[scriptColumn2].Value.ToString() + "\n";
                }                
            }
        }

        private void btnApagarIndice_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "";
                script = txtScriptDrop.Text;

                if (String.IsNullOrEmpty(script)) throw new Exception("Selecione ao menos um índice.");

                dbIndex.ExecuteScript(main.GetCredentials(), main.databaseSindex, script);
                dbServer.LoadIndexes(main.GetCredentials(), main.databaseSindex);
                main.ShowMessage("Script executado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaComando(string tipo, string comando)
        {
            string err = "";
            string acao = "";

            if (tipo == "D") acao = "criação";
            if (tipo == "C") acao = "exclusão";

            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPDATABASE") > -1) err += "Comando com DROP DATABASE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPTABLE") > -1) err += "Comando com DROP TABLE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPPROC") > -1) err += "Comando com DROP PROCEDURE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPFUNCTION") > -1) err += "Comando com DROP FUNCTION.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPTRIGGER") > -1) err += "Comando com DROP TRIGGER.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPVIEW") > -1) err += "Comando com DROP VIEW.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DROPSEQUENCE") > -1) err += "Comando com DROP SEQUENCE.\n";

            if (comando.ToUpper().Replace(" ", "").IndexOf("ALTERTABLE") > -1) err += "Comando com ALTER TABLE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("ALTERDATABASE") > -1) err += "Comando com ALTER DATABASE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("ALTERPROC") > -1) err += "Comando com ALTER PROCEDURE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("ALTERVIEW") > -1) err += "Comando com ALTER VIEW.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("ALTERFUNCTION") > -1) err += "Comando com ALTER FUNCTION.\n";

            if (comando.ToUpper().Replace(" ", "").IndexOf("CREATETABLE") > -1) err += "Comando com CREATE TABLE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("CREATEDATABASE") > -1) err += "Comando com CREATE DATABASE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("CREATEPROC") > -1) err += "Comando com CREATE PROCEDURE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("CREATEVIEW") > -1) err += "Comando com CREATE VIEW.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("CREATEFUNCTION") > -1) err += "Comando com CREATE FUNCTION.\n";

            if (comando.ToUpper().Replace(" ", "").IndexOf("INSERTINTO") > -1) err += "Comando com INSERT.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("FROM") > -1) err += "Comando com SELECT.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("DELETE") > -1) err += "Comando com DELETE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("UPDATE") > -1) err += "Comando com UPDATE.\n";
            if (comando.ToUpper().Replace(" ", "").IndexOf("USE") > -1) err += "Comando com USE DATABASE.\n";

            if (err != "")
            {
                if (main.ShowMessage("Foi identificado os seguintes comandos na "+acao+" do(s) índice(s), deseja continuar?\n" + err, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    throw new Exception("Execução cancelada");
                }
            }
        }

        private void btnCriarIndice_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "BEGIN TRY\nBEGIN TRAN;";

                script += txtScriptDrop.Text+"\n";
                script += txtScriptCreate.Text+"\n";
                script += "COMMIT TRAN;\nEND TRY\nBEGIN CATCH\nROLLBACK;THROW;\nEND CATCH";

                ValidaComando("D", txtScriptDrop.Text);
                ValidaComando("C", txtScriptCreate.Text);

                if (String.IsNullOrEmpty(txtScriptDrop.Text) || String.IsNullOrEmpty(txtScriptCreate.Text))
                    throw new Exception("Selecione ao menos um índice.");

                dbIndex.ExecuteScript(main.GetCredentials(), main.databaseSindex, script);
                dbServer.LoadIndexes(main.GetCredentials(), main.databaseSindex);
                main.ShowMessage("Script executado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
