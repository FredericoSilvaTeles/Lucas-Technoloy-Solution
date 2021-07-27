﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public class InputEntity
	{
		[JsonProperty(PropertyName = "id")]
		public Guid? Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; } = "";

		[JsonProperty(PropertyName = "label")]
		public string Label { get; set; } = "";

		[JsonProperty(PropertyName = "labelPlural")]
		public string LabelPlural { get; set; } = "";

		[JsonProperty(PropertyName = "system")]
		public bool? System { get; set; } = false;

		[JsonProperty(PropertyName = "iconName")]
		public string IconName { get; set; } = "";

		[JsonProperty(PropertyName = "color")]
		public string Color { get; set; } = "";

		[JsonProperty(PropertyName = "recordPermissions")]
		public RecordPermissions RecordPermissions { get; set; }

		[JsonProperty(PropertyName = "record_screen_id_field")]
		public Guid? RecordScreenIdField { get; set; } //If null the ID field of the record is used as ScreenId
	}

	[Serializable]
	public class Entity
	{
		[JsonProperty(PropertyName = "id")]
		public Guid Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; } = "";

		[JsonProperty(PropertyName = "label")]
		public string Label { get; set; } = "";

		[JsonProperty(PropertyName = "labelPlural")]
		public string LabelPlural { get; set; } = "";

		[JsonProperty(PropertyName = "system")]
		public bool System { get; set; } = false;

		[JsonProperty(PropertyName = "iconName")]
		public string IconName { get; set; } = "";

		[JsonProperty(PropertyName = "color")]
		public string Color { get; set; } = "";

		[JsonProperty(PropertyName = "recordPermissions")]
		public RecordPermissions RecordPermissions { get; set; }

		[JsonProperty(PropertyName = "fields")]
		public List<Field> Fields { get; set; }

		[JsonProperty(PropertyName = "record_screen_id_field")]
		public Guid? RecordScreenIdField { get; set; } //If null the ID field of the record is used as ScreenId

		[JsonProperty(PropertyName = "hash")]
		public string Hash { get; internal set; }

		public override string ToString()
		{
			return Name;
		}
	}

	[Serializable]
	public class RecordPermissions
	{
		[JsonProperty(PropertyName = "canRead")]
		public List<Guid> CanRead { get; set; } = new List<Guid>();

		[JsonProperty(PropertyName = "canCreate")]
		public List<Guid> CanCreate { get; set; } = new List<Guid>();

		[JsonProperty(PropertyName = "canUpdate")]
		public List<Guid> CanUpdate { get; set; } = new List<Guid>();

		[JsonProperty(PropertyName = "canDelete")]
		public List<Guid> CanDelete { get; set; } = new List<Guid>();
	}

	public class EntityResponse : BaseModel
	{
		[JsonProperty(PropertyName = "object")]
		public Entity Object { get; set; }
	}

	public class EntityListResponse : BaseModel
	{
		[JsonProperty(PropertyName = "object")]
		public List<Entity> Object { get; set; }
	}

	public class EntityLibraryItemsResponse : BaseModel
	{
		[JsonProperty(PropertyName = "object")]
		public List<object> Object { get; set; }
	}
}
