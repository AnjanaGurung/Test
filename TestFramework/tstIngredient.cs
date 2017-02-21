using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstIngredient
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the 
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //test to see that it exists
            Assert.IsNotNull(AnIngredient);  
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnIngredient.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.Active, TestData);  
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnIngredient.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.DateAdded, TestData);  
        }


        [TestMethod]
        public void CakeIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnIngredient.CakeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.CakeID, TestData);  
        }

        [TestMethod]
        public void IngredientIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnIngredient.IngredientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.IngredientID, TestData); 
        }

        [TestMethod]
        public void IngredientQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnIngredient.IngredientQuantity = TestData; 
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.IngredientQuantity, TestData);    
        }

        [TestMethod]
        public void IngredientNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            string TestData = "Egg";
            //assign the data to the property
            AnIngredient.IngredientName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.IngredientName, TestData);  
        }



        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsIngredient AIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string SomeIngredient = "Egg";
            //invoke the method
            OK = AIngredient.Valid(SomeIngredient);  
            //test to see that the result is correct
            Assert.IsTrue(OK); 
        }



        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //test to see that the result is correct
            Assert.IsTrue(Found); 
        }


        [TestMethod]
        public void TestIngredientIDFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //check the address no
            if (AnIngredient.IngredientID != 1)  
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIngredientQuantityFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //check the address no
            if (AnIngredient.IngredientQuantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





    }
}
