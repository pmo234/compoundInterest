using System;
using Xunit;
using Compound_Interest;
namespace Compound_Interest_Tests;

public class CompoundInterestTest
{
   

    [Fact]
    public void TestProductA()
    {
        //Arrange
        double expected = 10300;
        //Act
        double actual = Compound_Interest_Calculator.InterestProductA(10000);
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestProductB()
    {
        //Arrange
        double expected = 10598.70;
        //Act
        double actual = Compound_Interest_Calculator.InterestProductB(2,10000);
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestProductC()
    {
        //Arrange
        double expected = 10609;
        //Act
        double actual = Compound_Interest_Calculator.InterestProductC(2, 10000,3);
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void CanTestThatFunctionWillChooseBestProductToInvestIn()
    {

        double product1Interest = Compound_Interest_Calculator.InterestProductA(10000);
        double product2Interest = Compound_Interest_Calculator.InterestProductB(24, 10000);
        //Arrange
        string expected = "Emma, Product 2 would give you £9792.43 more interest.";
        //Act
        string actual = ProductComparer.CompareProducts("Emma",product1Interest,product2Interest);
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void WillSayIfBothCompaniesGiveTheSameInterest()
    {

        double product1Interest = Compound_Interest_Calculator.InterestProductC(3,10000,10);
        double product2Interest = Compound_Interest_Calculator.InterestProductC(1, 10000,33.1);
        //Arrange
        string expected = "Emma, both products give the same amount of interest.";
        //Act
        string actual = ProductComparer.CompareProducts("Emma", product1Interest, product2Interest);
        //Assert
        Assert.Equal(expected, actual);
    }

}

