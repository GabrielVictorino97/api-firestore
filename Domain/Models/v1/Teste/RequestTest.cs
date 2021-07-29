using MediatR;

namespace Domain.Model.v1.Teste
{
    public class RequestTest : IRequest<string>
    {
        public RequestTest(string name, string race, string weapon)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
        }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Weapon { get; set; }
    }
}
