using Moq;
using System;
using Xunit;
using LabT2Dependency;
using LabT2Dependency.Controllers;
using System.Data.Entity;
using LabT2Dependency.Models;
using System.Collections.Generic;

namespace Lab2TDependency.Tests
{
    public class UnitTest1 
    {
        

        [Fact]
        public void ShouldReturnAllJourneys()
        {

            
            var mockService = new Mock<IApiRequestSend<Journey>>();
            var controller = new TravelApiController(mockService.Object);

            var data= controller.GetAllJourneys();



            mockService.Verify(m => m.GetAllData(), Times.Once());

        }
        [Fact]
        public void ShouldDeleteJourney()
        {

            Journey journey = new Journey();

            var mockService = new Mock<IApiRequestSend<Journey>>();
            var controller = new TravelApiController(mockService.Object);

            controller.DeleteJourney(journey);



            mockService.Verify(m => m.DeleteEntity(journey), Times.Once());

        }
        [Fact]
        public void ShouldAddNewJourney()
        {

            Journey journey = new Journey();

            var mockService = new Mock<IApiRequestSend<Journey>>();
            var controller = new TravelApiController(mockService.Object);

            controller.AddJourney(journey);



            mockService.Verify(m => m.AddEntity(journey), Times.Once());

        }
       
        [Fact]
        public void ShouldModifyJourney()
        {
            var journey = new Journey();
         
            journey.Id = 1;

            var mockService = new Mock<IApiRequestSend<Journey>>();

            var controller = new TravelApiController(mockService.Object);
            controller.ModifyJourney(journey.Id, new Journey());

            mockService.Verify(m => m.ModifyEntity(journey.Id, It.Is<Journey>(j => j.Id != journey.Id)), Times.Once());
        }

    }
}
