using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xamarin.Auth.SampleData
{
    partial class ClassSensitive<T>
    {
        private T data;

        partial void InitializePrivateSecureSecretCritical();

        public ClassSensitive()
        {
            // initialize non secure data
            this.InitializePublicUnSecureNonCritical();

            // initialize secure data
            // this method will be NOOP-ed 
            this.InitializePrivateSecureSecretCritical();


        }
    }
}
