namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9cdba395-68f3-4195-8ca5-17e964c810f2");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5644c772-7dae-444c-96a5-14ec7542f86d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,193,110,219,48,12,189,7,232,63,16,198,80,216,64,32,180,59,174,93,129,37,203,134,0,69,59,52,201,46,195,14,138,204,164,26,100,201,147,228,116,89,145,127,31,101,57,173,107,103,69,118,27,47,73,168,199,71,62,242,69,243,2,93,201,5,194,28,173,229,206,172,60,27,27,189,146,235,202,114,47,141,62,25,60,158,12,128,162,114,82,175,97,182,117,30,139,139,118,170,93,88,20,70,255,245,209,34,155,104,47,189,68,119,12,134,77,54,168,253,30,250,173,78,111,235,220,181,164,33,52,218,116,38,238,177,224,55,164,1,222,67,178,112,246,14,185,242,219,36,251,30,139,202,106,169,164,0,161,184,115,16,223,14,208,192,59,24,113,135,7,94,34,75,179,128,22,161,217,208,200,50,71,216,24,153,195,173,158,241,13,9,73,205,242,7,10,15,14,117,142,118,8,145,112,132,43,82,85,211,126,176,107,7,152,61,211,181,152,67,44,105,10,246,196,182,167,193,236,226,37,44,242,130,173,245,144,240,52,38,178,88,208,1,231,40,100,193,21,148,86,138,176,165,88,197,62,163,159,111,75,204,199,70,85,133,254,202,85,133,151,13,244,42,13,155,252,18,240,139,217,199,164,219,93,174,32,141,100,87,112,126,182,143,236,37,168,35,44,4,178,169,27,115,45,80,97,78,115,120,91,33,49,247,113,206,219,96,10,178,165,227,107,156,99,81,42,238,195,228,26,31,224,218,8,174,228,111,190,84,56,171,113,105,163,103,225,208,146,111,53,237,159,76,203,238,208,153,202,10,2,25,75,44,195,126,155,16,207,142,137,86,75,134,144,244,58,56,86,111,103,234,230,198,140,228,58,254,74,50,54,55,205,4,217,17,50,104,252,152,96,159,140,45,184,79,59,242,168,241,57,59,27,189,233,109,59,132,191,183,230,161,150,63,249,37,176,12,2,247,245,93,248,110,48,232,141,32,232,95,73,234,94,191,125,196,198,211,143,99,1,205,210,102,147,171,230,236,151,240,54,92,28,78,79,247,154,166,238,166,82,234,214,78,138,210,111,211,166,95,150,181,138,31,59,162,14,153,97,208,193,252,127,70,104,22,115,135,63,43,105,49,63,206,10,255,102,132,254,253,95,189,126,11,187,123,250,190,139,20,244,177,251,3,199,219,224,98,223,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
			LocalizableStrings.Add(CreateCommentRequiredLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eaa04b89-e842-0729-a86c-1c681820f704"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("5644c772-7dae-444c-96a5-14ec7542f86d"),
				CreatedInSchemaUId = new Guid("9cdba395-68f3-4195-8ca5-17e964c810f2"),
				ModifiedInSchemaUId = new Guid("9cdba395-68f3-4195-8ca5-17e964c810f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCommentRequiredLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6ddce27e-ce0b-35b6-ce94-67a4ad7e6892"),
				Name = "CommentRequired",
				CreatedInPackageId = new Guid("5644c772-7dae-444c-96a5-14ec7542f86d"),
				CreatedInSchemaUId = new Guid("9cdba395-68f3-4195-8ca5-17e964c810f2"),
				ModifiedInSchemaUId = new Guid("9cdba395-68f3-4195-8ca5-17e964c810f2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9cdba395-68f3-4195-8ca5-17e964c810f2"));
		}

		#endregion

	}

	#endregion

}

