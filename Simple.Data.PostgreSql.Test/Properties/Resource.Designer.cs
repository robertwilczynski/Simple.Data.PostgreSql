﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple.Data.PostgreSql.Test.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Simple.Data.PostgreSql.Test.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE public.array_types
        ///(
        ///  id                           serial NOT NULL,
        ///  integer_array_field          integer[],
        ///  real_array_field             real[],
        ///  double_precision_array_field double precision[],
        ///  varchar_array_field          varchar[],
        ///
        ///  integer_multi_array_field          integer[][],
        ///  real_multi_array_field             real[][],
        ///  double_precision_multi_array_field double precision[][],
        ///  varchar_multi_array_field          varchar[][],
        ///  
        ///  CONSTRAINT array_types_pkey
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ArrayTypes {
            get {
                return ResourceManager.GetString("ArrayTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///CREATE TABLE public.basic_types (
        ///  id                                 serial NOT NULL,
        ///  
        ///  smallint_field                     smallint,
        ///  integer_field                      integer,
        ///  bigint_field                       bigint,
        ///  decimal_unlimited_field            decimal,
        ///  decimal_10_2_field                 decimal(10,2),  
        ///  numeric_unlimited_field            numeric,
        ///  numeric_10_2_field                 numeric(10,2),                    
        ///  real_field                         real,
        ///  double_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BasicTypes {
            get {
                return ResourceManager.GetString("BasicTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///
        ///CREATE OR REPLACE FUNCTION public.test_return(double_me integer)
        ///RETURNS integer AS
        ///$$
        ///BEGIN
        ///  return 2 * double_me;
        ///END;
        ///$$
        ///LANGUAGE plpgsql;
        ///
        ///CREATE OR REPLACE FUNCTION public.test_return_no_parameter_names(integer)
        ///RETURNS integer AS
        ///$$
        ///BEGIN
        ///  return 2 * $1;
        ///END;
        ///$$
        ///LANGUAGE plpgsql;
        ///
        ///
        ///CREATE OR REPLACE FUNCTION public.test_out(double_me integer, OUT doubled integer )
        ///RETURNS integer AS
        ///$$
        ///BEGIN
        ///  doubled = 2 * double_me;
        ///END;
        ///$$
        ///LANGUAGE plpgsql;
        ///
        ///CREATE OR REPLACE FUNCT [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProcedureTest {
            get {
                return ResourceManager.GetString("ProcedureTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///CREATE TABLE users (
        ///  id serial NOT NULL,
        ///  name varchar(100) NOT NULL,
        ///  password varchar(100) NOT NULL,
        ///  age integer NOT NULL
        ///) WITH (OIDS = FALSE);
        ///
        ///ALTER TABLE users
        ///  ADD CONSTRAINT pk_users
        ///  PRIMARY KEY (id);
        ///  
        ///INSERT INTO users (name, password, age) VALUES (&apos;Bob&apos;, &apos;Bob&apos;, 32);
        ///INSERT INTO users (name, password, age) VALUES (&apos;Charlie&apos;, &apos;Charlie&apos;, 49);
        ///INSERT INTO users (name, password, age) VALUES (&apos;Dave&apos;, &apos;Dave&apos;, 12);
        ///
        ///
        ///
        ///CREATE TABLE customers
        ///(
        ///  id serial NOT NULL,
        ///  name v [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Test {
            get {
                return ResourceManager.GetString("Test", resourceCulture);
            }
        }
    }
}
