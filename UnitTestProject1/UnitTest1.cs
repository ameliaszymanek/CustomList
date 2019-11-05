﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
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

        public void CustomList_Add_CheckIndexPositionOfValuesAdded()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = "Alma";
            int actual;
            int string1 = "Amelia";
            int string2 = "Andrew";
            int string3 = "Alma";

            //act


            //Assert

        }
    }
}
