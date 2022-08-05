namespace CommandsService.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HotTo { get; set; }
        public string CommandLine { get; set; }
        public int PlatformId { get; set; }
    }
}