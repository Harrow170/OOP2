﻿using OOP2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Model
{
    /// <summary>
    /// Has the data about the address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Postal code.
        /// </summary>
        private int _index;

        /// <summary>
        /// Country/region.
        /// </summary>
        private string _country = string.Empty;

        /// <summary>
        /// City.
        /// </summary>
        private string _city = string.Empty;

        /// <summary>
        /// Street.
        /// </summary>
        private string _street = string.Empty;

        /// <summary>
        /// House number.
        /// </summary>
        private string _building = string.Empty;

        /// <summary>
        /// Apartment number.
        /// </summary>
        private string _apartment = string.Empty;

        /// <summary>
        /// Gets and sets a postal index. Supposed to have 6 numbers in it.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100000, 999999, "Index");
                _index = value;
            }
        }


        /// <summary>
        /// Gets and sets country/region. Not lonegr than 50 symbols.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }

        /// <summary>
        /// Gets and sets a city. Not longer than 50 symbols.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");
                _city = value;
            }
        }

        /// <summary>
        /// Gets and sets a street. Not longer than 100 symbols.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");
                _street = value;
            }
        }

        /// <summary>
        /// Gets and ssets a house number. Not longer than 10 symbols.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Building");
                _building = value;
            }
        }

        /// <summary>
        /// Gets and ssets an apartment. Not longer than 10 symbols.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                _apartment = value;
            }
        }


        /// <summary>
        /// Creates a sample of the class <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город(населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер кватиры или помещения.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Creates a sample of the class <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

    }
}