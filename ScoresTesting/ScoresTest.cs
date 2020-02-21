using ScoresEncapsulated;
using System;
using Xunit;


namespace ScoresTesting
{
    public class ScoresTest
    {
        [Fact]
        public void Test1()
        {
           

            //arrange
            GradeBook gradeBook = new GradeBook();
            gradeBook.Addgrade(57.3);
            gradeBook.Addgrade(79.4);
            gradeBook.Addgrade(98.5);
            gradeBook.Addgrade(55.3);
            //act
           var stat= gradeBook.GetStatistics();
            //assert
            Assert.Equal(55.3, stat.Lowgrade);


        }
        [Fact]
        public void Test2()
        {
            //arrange
            GradeBook gradeBook = new GradeBook();
            gradeBook.Addgrade(57.3);
            gradeBook.Addgrade(79.4);
            gradeBook.Addgrade(98.5);
            gradeBook.Addgrade(55.3);
            //act
            var stat = gradeBook.GetStatistics();
            //assert
     
            Assert.Equal(98.5, stat.Highgrade);

        }
        [Fact]
        public void Test3()
        {


            //arrange
            GradeBook gradeBook = new GradeBook();
            gradeBook.Addgrade(57.3);
            gradeBook.Addgrade(79.4);
            gradeBook.Addgrade(98.5);
            gradeBook.Addgrade(55.3);
            //act
            var stat = gradeBook.GetStatistics();
            //assert
       
            Assert.Equal(98.5, stat.Highgrade);


        }
    }
}
