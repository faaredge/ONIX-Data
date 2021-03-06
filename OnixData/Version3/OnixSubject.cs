﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Version3
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixSubject
    {
        #region CONSTANTS

        public const int CONST_SUBJ_SCHEME_BISAC_CAT_ID = 10;
        public const int CONST_SUBJ_SCHEME_REGION_ID    = 11;

        #endregion

        public OnixSubject()
        {
            MainSubject = SubjectCode = "";

            SubjectSchemeIdentifier = SubjectSchemeVersion = -1;
        }

        private string mainSubjectField;
        private int    subjectSchemeIdentifierField;
        private int    subjectSchemeVersionField;
        private string subjectCodeField;

        #region Reference Tags

        /// <remarks/>
        public string MainSubject
        {
            get
            {
                return this.mainSubjectField;
            }
            set
            {
                this.mainSubjectField = value;
            }
        }

        /// <remarks/>
        public int SubjectSchemeIdentifier
        {
            get
            {
                return this.subjectSchemeIdentifierField;
            }
            set
            {
                this.subjectSchemeIdentifierField = value;
            }
        }

        /// <remarks/>
        public int SubjectSchemeVersion
        {
            get
            {
                return this.subjectSchemeVersionField;
            }
            set
            {
                this.subjectSchemeVersionField = value;
            }
        }

        /// <remarks/>
        public string SubjectCode
        {
            get
            {
                return this.subjectCodeField;
            }
            set
            {
                this.subjectCodeField = value;
            }
        }

        #endregion

        #region Short Tags

        /// <remarks/>
        public string x425
        {
            get { return MainSubject; }
            set { MainSubject = value; }
        }

        /// <remarks/>
        public int b067
        {
            get { return SubjectSchemeIdentifier; }
            set { SubjectSchemeIdentifier = value; }
        }

        /// <remarks/>
        public string b069
        {
            get { return SubjectCode; }
            set { SubjectCode = value; }
        }


        /// <remarks/>
        public int b068
        {
            get { return SubjectSchemeVersion; }
            set { SubjectSchemeVersion = value; }
        }

        #endregion
    }
}
