using Castle.Core.Logging;
using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Threading;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Handlers;

public class TestRequest : IRequest<TestModel>
{
    public TestModel Test {  get; set; }

    public TestRequest(TestModel test)
    {
        Test = test;
    }
}

public class TestHandler: IRequestHandler<TestRequest, TestModel>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<TestModel> _logger;

    public TestHandler(IUnitOfWork unitOfWork, ILogger<TestModel> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<TestModel> Handle(TestRequest request, CancellationToken cancellationToken)
    {
        //Test czy dziiała UnitOfWork
        var s =_unitOfWork.Users.ToString();
        await Task.Run(() => request.Test.Name = "Jo mama test");

        _logger.LogError("Jo mama gej hahaha");

        return request.Test;
    }
}
