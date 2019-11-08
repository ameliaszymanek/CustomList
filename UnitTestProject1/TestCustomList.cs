using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCustomList
    {
        ///////////// ADD TEST METHODS //////////
        [TestMethod]
        public void CustomList_Add_AddOneValueToListCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;
            int number1 = 3;

            //act
            list1.Add(number1);
            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CustomList_Count_CountIs0WithNoValuesInList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 0;
            int actual;

            //act
            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CustomList_Add_AddingValuesThatResizeArray()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 5;
            int actual;
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingValuesThatResizeArray2()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 9;
            int actual;
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int number6 = 6;
            int number7 = 7;
            int number8 = 8;
            int number9 = 9;


            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            list1.Add(number6);
            list1.Add(number7);
            list1.Add(number8);
            list1.Add(number9);

            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingStringValuesToListCount()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = 1;
            int actual;
            string string1 = "hello";

            //act
            list1.Add(string1);
            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_CheckIndexPositionOfValuesAdded()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "Alma";
            string actual;
            string string1 = "Amelia";
            string string2 = "Andrew";
            string string3 = "Alma";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            actual = list1[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_Adding5ValuesArrayCapacity()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 500;
            int actual;
            int number1 = 100;
            int number2 = 200;
            int number3 = 300;
            int number4 = 400;
            int number5 = 500;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1[4];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        ///////// REMOVE TEST METHODS /////////
        
        [TestMethod]
        public void CustomList_Remove_RemoveOneValueFromListCheckCount()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = 3;
            int actual;
            string string1 = "Soprano";
            string string2 = "Alto";
            string string3 = "Tenor";
            string string4 = "Baritone";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove(list1[3]);
            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemoveMultipleValuesFromListCheckCount()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = 1;
            int actual;
            string string1 = "Soprano";
            string string2 = "Alto";
            string string3 = "Tenor";
            string string4 = "Baritone";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove("Soprano");
            list1.Remove("Alto");
            list1.Remove("Tenor");
            actual = list1.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CustomList_Remove_RemoveValueShiftCheckNewStringAtZeroIndex()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "Alto";
            string actual;
            string string1 = "Soprano";
            string string2 = "Alto";
            string string3 = "Tenor";
            string string4 = "Baritone";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove("Soprano");
            //actual string at index 0 in list 1
            actual = list1[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemoveValueCheckNewStringAtIndex2()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "Baritone";
            string actual;
            string string1 = "Soprano";
            string string2 = "Alto";
            string string3 = "Tenor";
            string string4 = "Baritone";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove("Tenor");
            actual = list1[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /////// TO STRING ///////
        [TestMethod]
        //bool
        //char 
        public void CustomList_ToString_IntToString()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            string expected = "1234";
            string actual;
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;

            //act
            list1.Add(int1);
            list1.Add(int2);
            list1.Add(int3);
            list1.Add(int4);
            actual = list1.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_ToString_DoubToString()
        {
            //arrange
            CustomList<double> list1 = new CustomList<double>();
            string expected = "88.9";
            string actual;
            double dbl1 = 88.9;

            //act
            list1.Add(dbl1);
            actual = list1.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_ToString_CharToString()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            string expected = "abc";
            string actual;
            char char1 = 'a';
            char char2 = 'b';
            char char3 = 'c';

            //act


            //Assert

        }




        //[TestMethod]
        //public void CustomList_ToString_AddTwoListsToString()
        //{
        //    //arrange
        //    CustomList<string> list1 = new CustomList<string>();
        //    CustomList<string> list2 = new CustomList<string>();
        //    string expected = "banana";
        //    string actual;
        //    string list1.string1 = "b";
        //    string list1.string2 = "a";
        //    string list1.string3 = "n";
        //    string list2.string1 = "a";
        //    string list2.string2 = "n";
        //    string list2.string3 = "a";

        //    //act

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}


    }
}
