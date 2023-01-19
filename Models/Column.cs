using System.Diagnostics.Metrics;

namespace TrelloBackend.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string? NameColumn { get; set; }

        public List<Card> Cards { get; set; } = new();
    }

    public class Card
    {
        public int Id { get; set; }
        public string? NameCard { get; set; }

        public int ColumnId { get; set; }      // внешний ключ
        public Column? Column { get; set; }    // навигационное свойство

    }
}
