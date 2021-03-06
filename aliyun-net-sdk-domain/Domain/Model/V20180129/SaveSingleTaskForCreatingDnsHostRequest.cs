/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveSingleTaskForCreatingDnsHostRequest : RpcAcsRequest<SaveSingleTaskForCreatingDnsHostResponse>
    {
        public SaveSingleTaskForCreatingDnsHostRequest()
            : base("Domain", "2018-01-29", "SaveSingleTaskForCreatingDnsHost")
        {
        }

		private string instanceId;

		private List<string> ips;

		private string dnsName;

		private string userClientIp;

		private string lang;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public List<string> Ips
		{
			get
			{
				return ips;
			}

			set
			{
				ips = value;
				for (int i = 0; i < ips.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Ip." + (i + 1) , ips[i]);
				}
			}
		}

		public string DnsName
		{
			get
			{
				return dnsName;
			}
			set	
			{
				dnsName = value;
				DictionaryUtil.Add(QueryParameters, "DnsName", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveSingleTaskForCreatingDnsHostResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForCreatingDnsHostResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
