using System.ComponentModel.DataAnnotations;

namespace Parcial3_VargasGaviriaJhoanSebastian.DAL.Entities
{
    public class Ticket : Entity
    {
        #region
        [Display(Name = "Ticket")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TicketID { get; set; }

        [Display(Name = "Fecha Activación")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Ticket Activo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool IsUsed { get; set; }

        [Display(Name = "Porteria")]
        public Entrance? EntranceGate { get; set; }

        public enum Entrance
        {
            Oriental,
            Occidental,
            Norte,
            Sur,

        }
    }
    #endregion
}