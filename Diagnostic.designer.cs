﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiagnosticApps
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DiagonesticDb")]
	public partial class DiagnosticDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Category(tbl_Category instance);
    partial void Updatetbl_Category(tbl_Category instance);
    partial void Deletetbl_Category(tbl_Category instance);
    partial void Inserttbl_Test(tbl_Test instance);
    partial void Updatetbl_Test(tbl_Test instance);
    partial void Deletetbl_Test(tbl_Test instance);
    #endregion
		
		public DiagnosticDataContext() : 
				base(global::DiagnosticApps.Properties.Settings.Default.DiagonesticDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DiagnosticDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DiagnosticDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DiagnosticDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DiagnosticDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Category> tbl_Categories
		{
			get
			{
				return this.GetTable<tbl_Category>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Test> tbl_Tests
		{
			get
			{
				return this.GetTable<tbl_Test>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Category")]
	public partial class tbl_Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private string _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    #endregion
		
		public tbl_Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Test")]
	public partial class tbl_Test : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TestID;
		
		private string _Category;
		
		private int _TestNo;
		
		private string _TestName;
		
		private int _RoomNo;
		
		private decimal _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTestIDChanging(int value);
    partial void OnTestIDChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnTestNoChanging(int value);
    partial void OnTestNoChanged();
    partial void OnTestNameChanging(string value);
    partial void OnTestNameChanged();
    partial void OnRoomNoChanging(int value);
    partial void OnRoomNoChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    #endregion
		
		public tbl_Test()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TestID
		{
			get
			{
				return this._TestID;
			}
			set
			{
				if ((this._TestID != value))
				{
					this.OnTestIDChanging(value);
					this.SendPropertyChanging();
					this._TestID = value;
					this.SendPropertyChanged("TestID");
					this.OnTestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestNo", DbType="Int NOT NULL")]
		public int TestNo
		{
			get
			{
				return this._TestNo;
			}
			set
			{
				if ((this._TestNo != value))
				{
					this.OnTestNoChanging(value);
					this.SendPropertyChanging();
					this._TestNo = value;
					this.SendPropertyChanged("TestNo");
					this.OnTestNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TestName
		{
			get
			{
				return this._TestName;
			}
			set
			{
				if ((this._TestName != value))
				{
					this.OnTestNameChanging(value);
					this.SendPropertyChanging();
					this._TestName = value;
					this.SendPropertyChanged("TestName");
					this.OnTestNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomNo", DbType="Int NOT NULL")]
		public int RoomNo
		{
			get
			{
				return this._RoomNo;
			}
			set
			{
				if ((this._RoomNo != value))
				{
					this.OnRoomNoChanging(value);
					this.SendPropertyChanging();
					this._RoomNo = value;
					this.SendPropertyChanged("RoomNo");
					this.OnRoomNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591