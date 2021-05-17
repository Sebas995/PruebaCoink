using System.ComponentModel.DataAnnotations;

namespace Coink.DTO
{
    /// <summary>
    /// Request of user
    /// </summary>
    public class UserReq
    {
        /// <summary>
        /// Id of user
        /// </summary>
        [Key]
        public int IdUser { get; set; }
        /// <summary>
        /// Name of user
        /// </summary>
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "El maximo de caracteres permitidos es 200")]
        public string Name { get; set; }
        /// <summary>
        /// LastName of user
        /// </summary>
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "El maximo de caracteres permitidos es 200")]
        public string LastName { get; set; }
        /// <summary>
        /// Phone of user
        /// </summary>
        [Required]
        public int Phone { get; set; }
        /// <summary>
        /// Address of user
        /// </summary>
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "El maximo de caracteres permitidos es 200")]
        public string Address { get; set; }
        /// <summary>
        /// City of user
        /// </summary>
        [Required]
        public int IdCity { get; set; }
        /// <summary>
        /// Active User (1: Active, 0:Inactive)
        /// </summary>
        public bool Active { get; set; }
    }

    /// <summary>
    /// Repsonse of user
    /// </summary>
    public class UserRes
    {
        /// <summary>
        /// Id of user
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// Name of user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// LastName of user
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Phone of user
        /// </summary>
        public int Phone { get; set; }
        /// <summary>
        /// Address of user
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// City of user
        /// </summary>
        public string NameCity { get; set; }
        /// <summary>
        /// Department of user
        /// </summary>
        public string NameDepartment { get; set; }
        /// <summary>
        /// Country of user
        /// </summary>
        public string NameCountry { get; set; }
        /// <summary>
        /// Active User (1: Active, 0:Inactive)
        /// </summary>
        public bool Active { get; set; }
    }
}
