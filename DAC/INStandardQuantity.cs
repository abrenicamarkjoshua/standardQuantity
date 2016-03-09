﻿namespace standardquantity
{
    using System;
    using PX.Data;
    using PX.Objects.IN;

    [System.SerializableAttribute()]
	public class INStandardQuantity : PX.Data.IBqlTable
	{
		#region ItemClassID
		public abstract class itemClassID : PX.Data.IBqlField
		{
		}
		protected string _ItemClassID;
		[PXDBString(10, IsUnicode = true)]
		[PXDefault()]
		[PXUIField(DisplayName = "Item Class ID")]
        [PXSelector(
                typeof(Search<INItemClass.itemClassID>)
            )]
        public virtual string ItemClassID
		{
			get
			{
				return this._ItemClassID;
			}
			set
			{
				this._ItemClassID = value;
			}
		}
		#endregion
		#region SiteID
		public abstract class siteID : PX.Data.IBqlField
		{
		}
		protected int? _SiteID;
		[PXDBInt()]
		[PXDefault()]
		[PXUIField(DisplayName = "Warehouse ID")]
        [PXSelector(
                typeof(Search<INSite.siteID, Where<INSite.siteID, IsNotNull, And<Match<Current<AccessInfo.userName>>>>>)
               )]
        public virtual int? SiteID
		{
			get
			{
				return this._SiteID;
			}
			set
			{
				this._SiteID = value;
			}
		}
		#endregion
		#region LocationCD
		public abstract class locationCD : PX.Data.IBqlField
		{
		}
		protected string _LocationCD;
		[PXDBString(30, IsUnicode = true)]
		[PXDefault()]
		[PXUIField(DisplayName = "Location ID")]
        [PXSelector(typeof(Search<INLocation.locationCD, Where<INLocation.siteID, Equal<Current<siteID>>>>))]
        public virtual string LocationCD
		{
			get
			{
				return this._LocationCD;
			}
			set
			{
				this._LocationCD = value;
			}
		}
		#endregion
		#region StandardQuantityID
		public abstract class standardQuantityID : PX.Data.IBqlField
		{
		}
		protected string _StandardQuantityID;
		[PXDBString(10, IsUnicode = true, IsKey = true)]
		[PXDefault()]
		[PXUIField(DisplayName = "Standard Quantity ID")]
		public virtual string StandardQuantityID
		{
			get
			{
				return this._StandardQuantityID;
			}
			set
			{
				this._StandardQuantityID = value;
			}
		}
		#endregion
		#region StandardQuantity
		public abstract class standardQuantity : PX.Data.IBqlField
		{
		}
		protected decimal? _StandardQuantity;
		[PXDBDecimal(2)]
		[PXDefault(TypeCode.Decimal,"0.00")]
		[PXUIField(DisplayName = "Standard Quantity")]
		public virtual decimal? StandardQuantity
		{
			get
			{
				return this._StandardQuantity;
			}
			set
			{
				this._StandardQuantity = value;
			}
		}
		#endregion
	}
}