// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of SQL Azure database as output.
    /// </summary>
    public partial class SqlAzureOutputDataSourceProperties
    {
        private string _database;
        
        /// <summary>
        /// Optional. Gets or sets the name of the SQL Azure database.
        /// </summary>
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// Optional. Gets or sets the password of the SQL Azure database.
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        private string _server;
        
        /// <summary>
        /// Optional. Gets or sets the server of the SQL Azure database.
        /// </summary>
        public string Server
        {
            get { return this._server; }
            set { this._server = value; }
        }
        
        private string _table;
        
        /// <summary>
        /// Optional. Gets or sets the table name of the SQL Azure database.
        /// </summary>
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }
        
        private string _user;
        
        /// <summary>
        /// Optional. Gets or sets the user name of the SQL Azure database.
        /// </summary>
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// SqlAzureOutputDataSourceProperties class.
        /// </summary>
        public SqlAzureOutputDataSourceProperties()
        {
        }
    }
}