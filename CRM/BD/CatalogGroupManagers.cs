namespace CRM.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatalogGroupManagers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogGroupManagers()
        {
            Managers = new HashSet<Managers>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [MaxLength(20, ErrorMessage = "���� '������' �� ������ ��������� ����� 20 ��������")]
        [MinLength(3, ErrorMessage = "���� '������' �� ������ ��������� ����� 3 ��������")]
        [RegularExpression(@"[^0-9!`~:;@$%^*()_=/\?<>,.]{1,20}", ErrorMessage = "����������� ������� ������")]
        public string Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Managers> Managers { get; set; }
    }
}
