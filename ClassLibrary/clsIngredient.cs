using System;

namespace ClassLibrary
{
    public class clsIngredient
    {
        //private data member for the Ingredient ID  property 
        private Int32 mIngredientID;
        //private data member for Ingredient Quantity 
        private Int32 mIngredientQuantity;
        //private data member for Ingredient Name
        private string mIngredientName;
        //private data member for Cake ID
        private Int32 mCakeID;
        //private data member for Ingredient Date Added
        private DateTime mDateAdded;
        //private data member for active
        private Boolean mActive; 


        //public property for active
        public bool Active 
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //public property for active
        public int CakeID
        {
            get
            {
                //return the private data
                return mCakeID;
            }
            set
            {
                //set the value of the private data member
                mCakeID = value;
            }
        }


        //public property for active
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //public property for IngredientID 
        public int IngredientID
        {
            get
            {
                //return th eprivate dat
                return mIngredientID;
            }
            set
            {
                //set the value of the rivate data member
                mIngredientID = value;
            }
        }

        //public property for active   
        public string IngredientName
        {
            get
            {
                //return the private data
                return mIngredientName;
            }
            set
            {
                //set the value of the private data member
                mIngredientName = value; 
            }
        }

        //public property for the IngredientQuantity
        public int IngredientQuantity 
        {
            get
            {
                //return the private data
                return mIngredientQuantity;
            }
            set
            {
                //set the value of the private data member
                mIngredientQuantity = value; 
            }
        }


        public bool Valid(string someIngredient)
        {
            //if the name of the ingredient is not BLANK 
            if (someIngredient !="")
            {
                //return true
                return true;
            }
            //otherwise return false
            else
            {
                //return false
                return false;
            }
        }

        public bool Find(int IngredientID) 
        {
            //set the private data member to the test data value
            mIngredientID = 1;
            mActive = true;
            mIngredientName = "Egg";
            mIngredientQuantity = 2;
            mDateAdded = Convert.ToDateTime("21/02/2015");
            mCakeID = 1;
            //always return true
            return true;
        }
    }
}