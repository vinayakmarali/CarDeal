﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("CarsInfoModel", "FK_Car_Brand", "Brand", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(CarEntityModel.Brand), "Car", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CarEntityModel.Car), true)]

#endregion

namespace CarEntityModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CarsInfoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CarsInfoEntities object using the connection string found in the 'CarsInfoEntities' section of the application configuration file.
        /// </summary>
        public CarsInfoEntities() : base("name=CarsInfoEntities", "CarsInfoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CarsInfoEntities object.
        /// </summary>
        public CarsInfoEntities(string connectionString) : base(connectionString, "CarsInfoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CarsInfoEntities object.
        /// </summary>
        public CarsInfoEntities(EntityConnection connection) : base(connection, "CarsInfoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Brand> Brands
        {
            get
            {
                if ((_Brands == null))
                {
                    _Brands = base.CreateObjectSet<Brand>("Brands");
                }
                return _Brands;
            }
        }
        private ObjectSet<Brand> _Brands;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Car> Cars
        {
            get
            {
                if ((_Cars == null))
                {
                    _Cars = base.CreateObjectSet<Car>("Cars");
                }
                return _Cars;
            }
        }
        private ObjectSet<Car> _Cars;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Brands EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBrands(Brand brand)
        {
            base.AddObject("Brands", brand);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Cars EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCars(Car car)
        {
            base.AddObject("Cars", car);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CarsInfoModel", Name="Brand")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Brand : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Brand object.
        /// </summary>
        /// <param name="brandId">Initial value of the BrandId property.</param>
        public static Brand CreateBrand(global::System.Int32 brandId)
        {
            Brand brand = new Brand();
            brand.BrandId = brandId;
            return brand;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BrandId
        {
            get
            {
                return _BrandId;
            }
            set
            {
                if (_BrandId != value)
                {
                    OnBrandIdChanging(value);
                    ReportPropertyChanging("BrandId");
                    _BrandId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("BrandId");
                    OnBrandIdChanged();
                }
            }
        }
        private global::System.Int32 _BrandId;
        partial void OnBrandIdChanging(global::System.Int32 value);
        partial void OnBrandIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String BrandName
        {
            get
            {
                return _BrandName;
            }
            set
            {
                OnBrandNameChanging(value);
                ReportPropertyChanging("BrandName");
                _BrandName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("BrandName");
                OnBrandNameChanged();
            }
        }
        private global::System.String _BrandName;
        partial void OnBrandNameChanging(global::System.String value);
        partial void OnBrandNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CarsInfoModel", "FK_Car_Brand", "Car")]
        public EntityCollection<Car> Cars
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Car>("CarsInfoModel.FK_Car_Brand", "Car");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Car>("CarsInfoModel.FK_Car_Brand", "Car", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CarsInfoModel", Name="Car")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Car : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Car object.
        /// </summary>
        /// <param name="carId">Initial value of the CarId property.</param>
        public static Car CreateCar(global::System.Int32 carId)
        {
            Car car = new Car();
            car.CarId = carId;
            return car;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CarId
        {
            get
            {
                return _CarId;
            }
            set
            {
                if (_CarId != value)
                {
                    OnCarIdChanging(value);
                    ReportPropertyChanging("CarId");
                    _CarId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CarId");
                    OnCarIdChanged();
                }
            }
        }
        private global::System.Int32 _CarId;
        partial void OnCarIdChanging(global::System.Int32 value);
        partial void OnCarIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> BrandId
        {
            get
            {
                return _BrandId;
            }
            set
            {
                OnBrandIdChanging(value);
                ReportPropertyChanging("BrandId");
                _BrandId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BrandId");
                OnBrandIdChanged();
            }
        }
        private Nullable<global::System.Int32> _BrandId;
        partial void OnBrandIdChanging(Nullable<global::System.Int32> value);
        partial void OnBrandIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Model
        {
            get
            {
                return _Model;
            }
            set
            {
                OnModelChanging(value);
                ReportPropertyChanging("Model");
                _Model = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Model");
                OnModelChanged();
            }
        }
        private global::System.String _Model;
        partial void OnModelChanging(global::System.String value);
        partial void OnModelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Costs
        {
            get
            {
                return _Costs;
            }
            set
            {
                OnCostsChanging(value);
                ReportPropertyChanging("Costs");
                _Costs = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Costs");
                OnCostsChanged();
            }
        }
        private Nullable<global::System.Int32> _Costs;
        partial void OnCostsChanging(Nullable<global::System.Int32> value);
        partial void OnCostsChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CarsInfoModel", "FK_Car_Brand", "Brand")]
        public Brand Brand
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Brand>("CarsInfoModel.FK_Car_Brand", "Brand").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Brand>("CarsInfoModel.FK_Car_Brand", "Brand").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Brand> BrandReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Brand>("CarsInfoModel.FK_Car_Brand", "Brand");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Brand>("CarsInfoModel.FK_Car_Brand", "Brand", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}