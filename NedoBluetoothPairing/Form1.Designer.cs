
namespace NedoBluetoothPairing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPorts = new System.Windows.Forms.Label();
            this.btnSearchDevice = new System.Windows.Forms.Button();
            this.lbxFoundedItems = new System.Windows.Forms.ListBox();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.txtPairingMacAddr = new System.Windows.Forms.TextBox();
            this.lblParingDevMac = new System.Windows.Forms.Label();
            this.lblFoundedItem = new System.Windows.Forms.Label();
            this.btnPair = new System.Windows.Forms.Button();
            this.lblPairingStatus = new System.Windows.Forms.Label();
            this.btnInitValues = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlPairing = new System.Windows.Forms.Panel();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlSearch.SuspendLayout();
            this.pnlPairing.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSerialPorts
            // 
            this.cbxSerialPorts.FormattingEnabled = true;
            this.cbxSerialPorts.Location = new System.Drawing.Point(46, 17);
            this.cbxSerialPorts.Name = "cbxSerialPorts";
            this.cbxSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cbxSerialPorts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(173, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(9, 20);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(31, 13);
            this.lblPorts.TabIndex = 2;
            this.lblPorts.Text = "Ports";
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.Location = new System.Drawing.Point(6, 6);
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Size = new System.Drawing.Size(93, 23);
            this.btnSearchDevice.TabIndex = 3;
            this.btnSearchDevice.Text = "Search Devices";
            this.btnSearchDevice.UseVisualStyleBackColor = true;
            this.btnSearchDevice.Click += new System.EventHandler(this.btnSearchDevice_Click);
            // 
            // lbxFoundedItems
            // 
            this.lbxFoundedItems.FormattingEnabled = true;
            this.lbxFoundedItems.Location = new System.Drawing.Point(6, 66);
            this.lbxFoundedItems.Name = "lbxFoundedItems";
            this.lbxFoundedItems.Size = new System.Drawing.Size(197, 95);
            this.lbxFoundedItems.TabIndex = 4;
            this.lbxFoundedItems.Click += new System.EventHandler(this.lbxFoundedItems_Click);
            this.lbxFoundedItems.SelectedIndexChanged += new System.EventHandler(this.lbxFoundedItems_SelectedIndexChanged);
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Location = new System.Drawing.Point(105, 11);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(58, 13);
            this.lblSearchStatus.TabIndex = 5;
            this.lblSearchStatus.Text = "Search Init";
            // 
            // txtPairingMacAddr
            // 
            this.txtPairingMacAddr.Location = new System.Drawing.Point(5, 34);
            this.txtPairingMacAddr.Name = "txtPairingMacAddr";
            this.txtPairingMacAddr.Size = new System.Drawing.Size(148, 20);
            this.txtPairingMacAddr.TabIndex = 6;
            // 
            // lblParingDevMac
            // 
            this.lblParingDevMac.AutoSize = true;
            this.lblParingDevMac.Location = new System.Drawing.Point(2, 18);
            this.lblParingDevMac.Name = "lblParingDevMac";
            this.lblParingDevMac.Size = new System.Drawing.Size(143, 13);
            this.lblParingDevMac.TabIndex = 7;
            this.lblParingDevMac.Text = "Pairing Device MAC Address";
            // 
            // lblFoundedItem
            // 
            this.lblFoundedItem.AutoSize = true;
            this.lblFoundedItem.Location = new System.Drawing.Point(2, 48);
            this.lblFoundedItem.Name = "lblFoundedItem";
            this.lblFoundedItem.Size = new System.Drawing.Size(74, 13);
            this.lblFoundedItem.TabIndex = 8;
            this.lblFoundedItem.Text = "FoundedItems";
            // 
            // btnPair
            // 
            this.btnPair.Location = new System.Drawing.Point(5, 60);
            this.btnPair.Name = "btnPair";
            this.btnPair.Size = new System.Drawing.Size(75, 23);
            this.btnPair.TabIndex = 9;
            this.btnPair.Text = "Pair";
            this.btnPair.UseVisualStyleBackColor = true;
            this.btnPair.Click += new System.EventHandler(this.btnPair_Click);
            // 
            // lblPairingStatus
            // 
            this.lblPairingStatus.AutoSize = true;
            this.lblPairingStatus.Location = new System.Drawing.Point(97, 65);
            this.lblPairingStatus.Name = "lblPairingStatus";
            this.lblPairingStatus.Size = new System.Drawing.Size(56, 13);
            this.lblPairingStatus.TabIndex = 10;
            this.lblPairingStatus.Text = "Pairing Init";
            // 
            // btnInitValues
            // 
            this.btnInitValues.Location = new System.Drawing.Point(312, 17);
            this.btnInitValues.Name = "btnInitValues";
            this.btnInitValues.Size = new System.Drawing.Size(78, 43);
            this.btnInitValues.TabIndex = 11;
            this.btnInitValues.Text = "Load Init Values";
            this.btnInitValues.UseVisualStyleBackColor = true;
            this.btnInitValues.Click += new System.EventHandler(this.btnInitValues_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lblFoundedItem);
            this.pnlSearch.Controls.Add(this.lbxFoundedItems);
            this.pnlSearch.Controls.Add(this.btnSearchDevice);
            this.pnlSearch.Controls.Add(this.lblSearchStatus);
            this.pnlSearch.Location = new System.Drawing.Point(11, 50);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(210, 166);
            this.pnlSearch.TabIndex = 12;
            // 
            // pnlPairing
            // 
            this.pnlPairing.Controls.Add(this.lblPairingStatus);
            this.pnlPairing.Controls.Add(this.btnPair);
            this.pnlPairing.Controls.Add(this.lblParingDevMac);
            this.pnlPairing.Controls.Add(this.txtPairingMacAddr);
            this.pnlPairing.Location = new System.Drawing.Point(227, 79);
            this.pnlPairing.Name = "pnlPairing";
            this.pnlPairing.Size = new System.Drawing.Size(170, 100);
            this.pnlPairing.TabIndex = 13;
            // 
            // btnTerminal
            // 
            this.btnTerminal.Location = new System.Drawing.Point(315, 193);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnTerminal.TabIndex = 14;
            this.btnTerminal.Text = ">>>";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 222);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 185);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnTerminal);
            this.Controls.Add(this.pnlPairing);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnInitValues);
            this.Controls.Add(this.lblPorts);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxSerialPorts);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlPairing.ResumeLayout(false);
            this.pnlPairing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSerialPorts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Button btnSearchDevice;
        private System.Windows.Forms.ListBox lbxFoundedItems;
        private System.Windows.Forms.Label lblSearchStatus;
        private System.Windows.Forms.TextBox txtPairingMacAddr;
        private System.Windows.Forms.Label lblParingDevMac;
        private System.Windows.Forms.Label lblFoundedItem;
        private System.Windows.Forms.Button btnPair;
        private System.Windows.Forms.Label lblPairingStatus;
        private System.Windows.Forms.Button btnInitValues;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlPairing;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

