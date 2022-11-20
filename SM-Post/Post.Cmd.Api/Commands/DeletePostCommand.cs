using CQRS.Core.Commands;

using System.Reflection.Metadata.Ecma335;

namespace Post.Cmd.Api.Commands
{
    public class DeletePostCommand: BaseCommand
    {
        public string UserName { get; set; }
    }
}
