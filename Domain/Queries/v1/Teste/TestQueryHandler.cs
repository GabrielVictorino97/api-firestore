using Domain.Model.v1.Teste;
using Domain.Models.v1.Player;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Queries.v1.Teste
{
    public class TestQueryHandler : IRequestHandler<RequestTest, string>
    {
        private readonly string _path = @"crud-api.json";
        private readonly FirestoreDb _firestoreDb;
        private readonly string projectId;

        public TestQueryHandler()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", _path);
            projectId = "crud-api-9f536";
            _firestoreDb = FirestoreDb.Create(projectId);
        }

        public Task<string> Handle(RequestTest request, CancellationToken cancellationToken)
        {
            CollectionReference collection = _firestoreDb.Collection("Players");

            var data = new PlayerModel(request.Name, request.Race, request.Weapon);
            Dictionary<string, object> data1 = new Dictionary<string, object>();

            ArrayList array = new ArrayList();
            array.Add(request.Name);
            array.Add(request.Race);
            array.Add(request.Weapon);

            data1.Add("My array", array);

            collection.AddAsync(data1);

            return Task.FromResult<string>("Olá mundo!! Eu fui criado pelo Gabriel!");
        }
    }
}
