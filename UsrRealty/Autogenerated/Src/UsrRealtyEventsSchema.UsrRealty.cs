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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,193,110,219,48,12,189,7,232,63,16,198,80,216,64,32,180,215,181,43,208,100,217,16,160,104,135,196,217,101,216,65,145,153,84,131,44,121,146,156,46,43,242,239,165,45,167,117,237,180,200,110,227,37,9,245,248,200,71,190,104,158,163,43,184,64,72,209,90,238,204,202,179,177,209,43,185,46,45,247,210,232,147,193,227,201,0,40,74,39,245,26,230,91,231,49,191,104,167,218,133,121,110,244,155,143,22,217,68,123,233,37,186,99,48,108,178,65,237,247,208,31,117,122,91,231,110,36,13,161,209,198,115,113,143,57,191,37,13,240,9,162,133,179,51,228,202,111,163,228,103,40,42,202,165,146,2,132,226,206,65,120,59,64,3,31,97,196,29,30,120,9,44,205,2,90,132,102,67,35,203,12,97,99,100,6,119,122,206,55,36,36,54,203,95,40,60,56,212,25,218,33,4,194,17,174,72,85,77,123,109,215,14,48,121,161,107,49,87,177,164,41,216,51,219,158,6,147,139,215,176,192,11,182,214,67,194,227,144,72,66,65,7,156,161,144,57,87,80,88,41,170,45,133,42,246,21,125,186,45,48,27,27,85,230,250,59,87,37,94,54,208,171,184,218,228,183,10,191,152,127,142,186,221,229,10,226,64,118,5,231,103,251,72,94,131,58,194,170,64,54,117,99,174,5,42,204,104,14,111,75,36,230,62,206,121,91,153,130,108,233,248,26,83,204,11,197,125,53,185,198,7,184,49,130,43,249,151,47,21,206,107,92,220,232,89,56,180,228,91,77,251,39,211,178,25,58,83,90,65,32,99,137,101,216,111,83,197,139,99,130,213,162,33,68,189,14,142,213,219,153,186,212,152,145,92,135,95,81,194,82,211,76,144,28,33,131,198,15,9,246,197,216,156,251,184,35,143,26,159,179,179,209,135,222,182,171,240,247,214,60,212,242,39,127,4,22,149,192,125,125,23,190,27,12,122,35,8,250,87,146,186,247,111,31,176,225,244,227,80,64,179,180,217,228,170,57,251,101,56,59,156,158,238,53,77,221,109,169,212,157,157,228,133,223,198,77,191,36,105,21,63,118,68,29,50,195,160,131,249,255,140,208,44,102,134,191,75,105,49,59,206,10,255,102,132,254,253,223,189,126,11,187,123,254,190,11,20,244,177,123,2,126,76,150,247,223,5,0,0 };
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

