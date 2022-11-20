using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommentCommand : BaseCommand
    {
        private string comment;
        private string userName;

        public string Comment { get => comment; set => comment = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
