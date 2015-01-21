﻿using System;

namespace MongoUtility.Security
{
    /// <summary>
    ///     资源
    /// </summary>
    /// <see cref="http://docs.mongodb.org/manual/reference/resource-document/#resource-document" />
    public class Resource
    {
        /// <summary>
        ///     资源类型
        /// </summary>
        public enum ResourceType
        {
            /// <summary>
            ///     Database and/or Collection Resource
            /// </summary>
            DataBase,

            /// <summary>
            ///     Cluster Resource
            /// </summary>
            Cluster,

            /// <summary>
            ///     any Resource
            /// </summary>
            Any
        }

        /// <summary>
        ///     数据集名称
        /// </summary>
        public String CollectionName;

        /// <summary>
        ///     数据库名称
        /// </summary>
        public String DataBaseName;

        /// <summary>
        /// </summary>
        public ResourceType Type;

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public String GetJsCode()
        {
            var Result = String.Empty;
            switch (Type)
            {
                case ResourceType.DataBase:
                    Result = " resource: {  db: '" + DataBaseName + "', collection: '" + CollectionName + "' } ";
                    break;
                case ResourceType.Cluster:
                    Result = " resource: { cluster : true } ";
                    break;
                case ResourceType.Any:
                    Result = " resource: { anyResource: true } ";
                    break;
            }
            return Result;
        }
    }
}