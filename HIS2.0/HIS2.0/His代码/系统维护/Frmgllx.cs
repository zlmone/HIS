using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TrasenFrame.Classes;
using TrasenClasses.GeneralControls;
using TrasenClasses.GeneralClasses;
using YpClass;
namespace ts_yp_xtwh
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Frmgllx : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private myDataGrid.myDataGrid myDataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button butsave;
		private System.Windows.Forms.Button butquit;
		private MenuTag _menuTag;
		private string _chineseName;
		private Form _mdiParent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.ComboBox cmbyjks;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Frmgllx(MenuTag menuTag,string chineseName,Form mdiParent)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			_menuTag=menuTag;
			_chineseName=chineseName;
			_mdiParent=mdiParent;
			this.Text=_chineseName;
            this.Text = this.Text + " [" + InstanceForm._menuTag.Jgbm + "]";
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.myDataGrid1 = new myDataGrid.myDataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbyjks = new System.Windows.Forms.ComboBox();
            this.butquit = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 454);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(768, 31);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 300;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 1001;
            // 
            // myDataGrid1
            // 
            this.myDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.myDataGrid1.CaptionVisible = false;
            this.myDataGrid1.DataMember = "";
            this.myDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.myDataGrid1.Location = new System.Drawing.Point(3, 21);
            this.myDataGrid1.Name = "myDataGrid1";
            this.myDataGrid1.Size = new System.Drawing.Size(762, 347);
            this.myDataGrid1.TabIndex = 0;
            this.myDataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.AllowSorting = false;
            this.dataGridTableStyle1.DataGrid = this.myDataGrid1;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.dataGridTextBoxColumn3,
            this.dataGridBoolColumn1,
            this.dataGridTextBoxColumn8,
            this.dataGridTextBoxColumn9});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "序号";
            this.dataGridTextBoxColumn1.Width = 40;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "药品子类型";
            this.dataGridTextBoxColumn2.Width = 150;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "药品类型";
            this.dataGridTextBoxColumn3.Width = 70;
            // 
            // dataGridBoolColumn1
            // 
            this.dataGridBoolColumn1.AllowNull = false;
            this.dataGridBoolColumn1.FalseValue = ((short)(0));
            this.dataGridBoolColumn1.HeaderText = "管理权限";
            this.dataGridBoolColumn1.NullValue = ((short)(0));
            this.dataGridBoolColumn1.TrueValue = ((short)(1));
            this.dataGridBoolColumn1.Width = 80;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "ypzlxid";
            this.dataGridTextBoxColumn8.NullText = "";
            this.dataGridTextBoxColumn8.ReadOnly = true;
            this.dataGridTextBoxColumn8.Width = 0;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "yplxid";
            this.dataGridTextBoxColumn9.ReadOnly = true;
            this.dataGridTextBoxColumn9.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbyjks);
            this.groupBox1.Controls.Add(this.butquit);
            this.groupBox1.Controls.Add(this.butsave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // cmbyjks
            // 
            this.cmbyjks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyjks.Location = new System.Drawing.Point(139, 31);
            this.cmbyjks.Name = "cmbyjks";
            this.cmbyjks.Size = new System.Drawing.Size(192, 23);
            this.cmbyjks.TabIndex = 5;
            this.cmbyjks.SelectedIndexChanged += new System.EventHandler(this.cmbyjks_SelectedIndexChanged);
            // 
            // butquit
            // 
            this.butquit.Location = new System.Drawing.Point(725, 21);
            this.butquit.Name = "butquit";
            this.butquit.Size = new System.Drawing.Size(128, 41);
            this.butquit.TabIndex = 4;
            this.butquit.Text = "退出(&Q)";
            this.butquit.Click += new System.EventHandler(this.butquit_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(576, 21);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(128, 41);
            this.butsave.TabIndex = 2;
            this.butsave.Text = "保存(&S)";
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "药剂科室";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.myDataGrid1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 371);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "药品类型及子类型";
            // 
            // Frmgllx
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(768, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Frmgllx";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmsccj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]


		private void Frmsccj_Load(object sender, System.EventArgs e)
		{
			try
			{
				//初始化
				DataTable myTb=new DataTable();
			
				for(int i=0;i<=this.myDataGrid1.TableStyles[0].GridColumnStyles.Count-1;i++) 
				{	
					if(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].GetType().ToString()=="System.Windows.Forms.DataGridBoolColumn")
						myTb.Columns.Add(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText,Type.GetType("System.Int16"));	
					else
						myTb.Columns.Add(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText,Type.GetType("System.String"));	
									   
					this.myDataGrid1.TableStyles[0].GridColumnStyles[i].MappingName=this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
					this.myDataGrid1.TableStyles[0].GridColumnStyles[i].NullText="";
				}
			
				this.myDataGrid1.DataSource=myTb;
				this.myDataGrid1.TableStyles[0].MappingName ="Tb";
                Yp.AddcmbYjks(cmbyjks, InstanceForm.BDatabase,InstanceForm._menuTag.Jgbm);
			
				if (InstanceForm.BCurrentUser.IsAdministrator==false){ cmbyjks.SelectedValue=InstanceForm.BCurrentDept.DeptId ;cmbyjks.Enabled=false;}
				AddData(Convert.ToInt32(cmbyjks.SelectedValue));
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}

		private void AddData(int deptid)
		{
			DataTable myTb=new DataTable();
			string ssql="";
			ssql="select 0 序号,b.mc 药品子类型,a.mc 药品类型,cast(0 as smallint) 管理权限,b.id ypzlxid,a.id yplxid from yp_yplx a,yp_ypzlx b where a.id=b.yplx order by a.id ";
			myTb=InstanceForm.BDatabase.GetDataTable(ssql);
			myTb.TableName="Tb";
			this.myDataGrid1.DataSource=myTb;
			this.myDataGrid1.TableStyles[0].MappingName ="Tb";

			DataTable tb=new DataTable();
			ssql="select ypzlx from yp_gllx where deptid="+deptid+"";
			tb=InstanceForm.BDatabase.GetDataTable(ssql);
			FunBase.AddRowtNo(tb);
			for (int i=0;i<=tb.Rows.Count-1;i++)
			{
				int ypzlxid=Convert.ToInt32(tb.Rows[i]["ypzlx"]);
				for(int j=0;j<=myTb.Rows.Count-1;j++)
				{
					int ypzlxid1=Convert.ToInt32(myTb.Rows[j]["ypzlxid"]);
					if (ypzlxid==ypzlxid1) myTb.Rows[j]["管理权限"]=(short)1;
				}
			}


		}


		private void butquit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butsave_Click(object sender, System.EventArgs e)
		{
            ts_HospData_Share.ts_update_log ts = new ts_HospData_Share.ts_update_log();
            Guid log_djid = Guid.Empty;
            DataTable tb = (DataTable)this.myDataGrid1.DataSource;
            string[] ss = new string[tb.Rows.Count+1];
			try
			{
				this.butsave.Enabled=false;
				InstanceForm.BDatabase.BeginTransaction();

				string ssql="";
				int deptid=Convert.ToInt32(cmbyjks.SelectedValue);
				

				ssql="delete from yp_gllx where deptid="+deptid+"";
				InstanceForm.BDatabase.DoCommand(ssql);

                //三院数据处理
                ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BCurrentUser.Name + "删除 【" + cmbyjks.Text + " 】所对应的药品管理类型", "yp_gllx", "deptid", deptid.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                ss[0] = log_djid.ToString();


				for(int i=0;i<=tb.Rows.Count-1;i++)
				{
					int yplx=Convert.ToInt32(Convertor.IsNull(tb.Rows[i]["yplxid"],"0"));
					int ypzlx=Convert.ToInt32(Convertor.IsNull(tb.Rows[i]["ypzlxid"],"0"));
					int glqx=Convert.ToInt32(Convertor.IsNull(tb.Rows[i]["管理权限"],"0"));
					if (glqx==1)
					{
						ssql="insert into yp_gllx(yplx,ypzlx,deptid)values("+yplx+","+ypzlx+","+deptid+") ";
						InstanceForm.BDatabase.DoCommand(ssql);

                        long newid = Convert.ToInt64(InstanceForm.BDatabase.GetDataTable("select @@IDENTITY").Rows[0][0]);
                        ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BCurrentUser.Name + "为 【" + cmbyjks + " 】添加【" + Convertor.IsNull(tb.Rows[i]["药品类型"], "0") + "】 管理类型", "yp_gllx", "id", newid.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                        ss[i+1] = log_djid.ToString();
					}
				}

				InstanceForm.BDatabase.CommitTransaction();

			}
			catch(System.Exception err)
			{
				this.butsave.Enabled=true;
				InstanceForm.BDatabase.RollbackTransaction();
				MessageBox.Show("发生错误"+err.Message);
                return;
			}

            try
            {
                //三院数据处理
                string msg = "";
                for (int i = 0; i <= ss.Length - 1; i++)
                {
                    if (Convertor.IsNull(ss[i], "") == "") continue;
                    string errtext = "";
                    ts_HospData_Share.ts_update_log tss = new ts_HospData_Share.ts_update_log();
                    ts_HospData_Share.ts_update_type ty = new ts_HospData_Share.ts_update_type((int)ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BDatabase);
                    if (ty.Bzx == 1 && ss[i]!="")
                    {
                        tss.Pexec_log(new Guid(ss[i]), InstanceForm.BDatabase, out errtext);
                        msg = msg + errtext;
                    }
                }

                MessageBox.Show("保存成功");
                this.butsave.Enabled = true;
                this.AddData(Convert.ToInt32(cmbyjks.SelectedValue));
            }
            catch (System.Exception err)
            {
                MessageBox.Show("发生错误" + err.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

		}

		private void cmbyjks_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cmbyjks.Text.Trim()!="" && cmbyjks.Text.Trim()!="System.Data.DataRowView"  && Convertor.IsNumeric(cmbyjks.Text)==false )
			{
				AddData(Convert.ToInt32(cmbyjks.SelectedValue));
			}
		}


	}
}
