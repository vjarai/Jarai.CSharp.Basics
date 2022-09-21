﻿using System;
using Xunit;

namespace Jarai.CSharp.Relation.Bidirectional.Tests
{
    public class PersonTests
    {

        [Fact]
        public void Kennt_den_eigenen_Namen()
        {
            // Arrange
            var person = new Person("Susi", "Sorglos");

            // Assert
            Assert.Equal("Susi", person.Vorname);
            Assert.Equal("Sorglos",person.Nachname);
        }

        [Fact]
        public void Kann_nicht_heiraten_wenn_selbst_verheiratet()
        {
            // Arrange
            var target = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");
            target.Heiraten(person2);

            var person3 = new Person("Max", "Mustermann");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => target.Heiraten(person3));
        }


        [Fact]
        public void Kann_nicht_heiraten_wenn_Partner_verheiratet()
        {
            // Arrange
            var target = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");
            var person3 = new Person("Max", "Mustermann");
            person2.Heiraten(person3);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => target.Heiraten(person2));
        }

        [Fact]
        public void Kann_sich_nicht_selbst_heiraten()
        {
            // Arrange
            var person = new Person("Fritz", "Müller");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => person.Heiraten(person));
        }


        [Fact]
        public void Kann_keine_null_heiraten()
        {
            // Arrange
            var person = new Person("Fritz", "Müller");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => person.Heiraten(null));
        }

        [Fact]
        public void Kann_sich_nicht_trennen_wenn_ledig()
        {
            // Arrange
            var person = new Person("Fritz", "Müller");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => person.Trennen());
        }


        [Fact]
        public void Beide_haben_jeweils_den_anderen_als_Partner_nach_heirat()
        {
            // Arrange
            var person1 = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");

            // Act
            person1.Heiraten(person2);

            // Act & Assert
            Assert.Equal(person2, person1.Partner);
            Assert.Equal(person1, person2.Partner);
        }

        [Fact]
        public void Kennt_den_Namen_des_Partners_nach_heirat()
        {
            // Arrange
            var person1 = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");

            // Act
            person1.Heiraten(person2);

            // Act & Assert
            Assert.Contains( "Susi", person2.ToString());
        }

        [Fact]
        public void Beide_haben_keinen_Partner_mehr_nach_trennung()
        {
            // Arrange
            var person1 = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");

            // Act
            person1.Heiraten(person2);
            person2.Trennen();

            // Act & Assert
            Assert.Null(person1.Partner);
            Assert.Null(person2.Partner);
        }
    }
}
