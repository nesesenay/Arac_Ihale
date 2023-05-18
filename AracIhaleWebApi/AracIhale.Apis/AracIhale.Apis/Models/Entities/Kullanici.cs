﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class Kullanici : IEntity
    {
        [Key]
        public int KullaniciID { get; set; }
        [Required]
        [StringLength(25)]
        public string Ad { get; set; }
        [Required]
        [StringLength(30)]
        public string Soyad { get; set; }
        [Required]
        [StringLength(15)]
        public string Telefon { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Sifre { get; set; }

        public string İl { get; set; }
        [Required]
        [StringLength(30)]
        public string İlce { get; set; }
        [Required]
        [StringLength(100)]
        public string Adres { get; set; }
        [Required]
        public int RolID { get; set; }



        [ForeignKey("RolID")]
        public Rol Rol { get; set; }
        public List<IhaleFiyat> IhaleFiyatlari { get; set; }
        public List<AracIhaleSahip> AracIhaleSahipleri { get; set; }
        public List<AracIhale> AracIhaleleri { get; set; }
        public List<Arac> Araclar { get; set; }
    }
}
