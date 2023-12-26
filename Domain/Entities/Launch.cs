﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("launch")]
    public class Launch : BaseEntity
    {
        [Column("api_guid")]
        public Guid ApiGuId { get; set; }
        [Column("url")]
        public string? Url { get; set; }
        [Column("launch_library_id")]
        public int? LaunchLibraryId { get; set; }
        [Column("slug")]
        public string? Slug { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("id_status")]
        public Guid? IdStatus { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(IdStatus))]
        public Status Status { get; set; }
        [Column("net")]
        public DateTime? Net { get; set; }
        [Column("window_end")]
        public DateTime? WindowEnd { get; set; }
        [Column("window_start")]
        public DateTime? WindowStart { get; set; }
        [Column("inhold")]
        public bool? Inhold { get; set; }
        [Column("tbd_time")]
        public bool? TbdTime { get; set; }
        [Column("tbd_date")]
        public bool? TbdDate { get; set; }
        [Column("probability")]
        public int? Probability { get; set; }
        [Column("hold_reason")]
        public string? HoldReason { get; set; }
        [Column("fail_reason")]
        public string? FailReason { get; set; }
        [Column("hashtag")]
        public string? Hashtag { get; set; }
        [Column("id_launch_service_provider")]
        public Guid? IdLaunchServiceProvider { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(IdLaunchServiceProvider))]
        public LaunchServiceProvider LaunchServiceProvider { get; set; }
        [Column("id_rocket")]
        public Guid? IdRocket { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(IdRocket))]
        public Rocket Rocket { get; set; }
        [Column("id_mission")]
        public Guid? IdMission { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(IdMission))]
        public Mission Mission { get; set; }
        [Column("id_pad")]
        public Guid? IdPad { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(IdPad))]
        public Pad Pad { get; set; }
        [Column("web_cast_live")]
        public bool? WebcastLive { get; set; }
        [Column("image")]
        public string? Image { get; set; }
        [Column("infographic")]
        public string? Infographic { get; set; }
        [Column("programs")]
        public string? Programs { get; set; }
        [Column("search")]
        [JsonIgnore]
        public string? Search { get; set; }
    }
}
