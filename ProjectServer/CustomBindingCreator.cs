using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer
{
    public sealed class CustomBindingCreator
    {

        public static void snippetSecurity()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding();
            WSHttpSecurity whSecurity = wsHttpBinding.Security;
        }


        public static void snippetCreateBindingElements()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding();
            BindingElementCollection beCollection = wsHttpBinding.CreateBindingElements();
        }


        private void snippetCreateMessageSecurity()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding();
            // SecurityBindingElement sbe = wsHttpBinding
        }

        public static void snippetGetTransport()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding();
            //		TransportBindingElement tbElement = wsHttpBinding.GetTransport();
        }

        public static void snippetAllowCookies()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding();
            wsHttpBinding.AllowCookies = true;
        }

        public static Binding GetBinding()
        {
            // securityMode is Message
            // reliableSessionEnabled is true
            WSHttpBinding binding = new WSHttpBinding(SecurityMode.Message, true);
            binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;

            WSHttpSecurity security = binding.Security;
            return binding;

        }

        public static Binding GetBinding2()
        {

            // The security mode is set to Message.
            WSHttpBinding binding = new WSHttpBinding(SecurityMode.Message);
            binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            return binding;

        }

        // This method creates a WSFederationHttpBinding.
        public static WSFederationHttpBinding CreateWSFederationHttpBinding()
        {
            // Create an instance of the WSFederationHttpBinding
            WSFederationHttpBinding b = new WSFederationHttpBinding();

            // Set the security mode to Message
            b.Security.Mode = WSFederationHttpSecurityMode.Message;

            // Set the Algorithm Suite to Basic256Rsa15
            b.Security.Message.AlgorithmSuite = SecurityAlgorithmSuite.Basic256Rsa15;

            // Set NegotiateServiceCredential to true
            b.Security.Message.NegotiateServiceCredential = true;

            // Set IssuedKeyType to Symmetric
            b.Security.Message.IssuedKeyType = SecurityKeyType.SymmetricKey;

            // Set IssuedTokenType to SAML 1.1
            b.Security.Message.IssuedTokenType = "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#samlv1.1";

            // Extract the STS certificate from the certificate store
            X509Store store = new X509Store(StoreName.TrustedPeople, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certs = store.Certificates.Find(X509FindType.FindByThumbprint, "cd 54 88 85 0d 63 db ac 92 59 05 af ce b8 b1 de c3 67 9e 3f", false);
            store.Close();

            // Create an EndpointIdentity from the STS certificate
            EndpointIdentity identity = EndpointIdentity.CreateX509CertificateIdentity(certs[0]);

            // Set the IssuerAddress using the address of the STS and the previously created EndpointIdentity
            b.Security.Message.IssuerAddress = new EndpointAddress(new Uri("http://localhost:8000/sts/x509"), identity);

            // Set the IssuerBinding to a WSHttpBinding loaded from config
            b.Security.Message.IssuerBinding = new WSHttpBinding("Issuer");

            // Set the IssuerMetadataAddress using the metadata address of the STS and the previously created EndpointIdentity
            b.Security.Message.IssuerMetadataAddress = new EndpointAddress(new Uri("http://localhost:8001/sts/mex"), identity);

            // Create a ClaimTypeRequirement
            ClaimTypeRequirement ctr = new ClaimTypeRequirement("http://example.org/claim/c1", false);

            // Add the ClaimTypeRequirement to ClaimTypeRequirements
            b.Security.Message.ClaimTypeRequirements.Add(ctr);

            // Return the created binding
            return b;
        }


    }
}
