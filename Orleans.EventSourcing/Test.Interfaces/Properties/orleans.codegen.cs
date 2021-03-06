//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Test.Interfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using Test.Interfaces;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class PersonFactory
    {
        

                        public static Test.Interfaces.IPerson GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Test.Interfaces.IPerson), -627797884, primaryKey));
                        }

                        public static Test.Interfaces.IPerson GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Test.Interfaces.IPerson), -627797884, primaryKey, grainClassNamePrefix));
                        }

                        public static Test.Interfaces.IPerson GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Test.Interfaces.IPerson), -627797884, primaryKey));
                        }

                        public static Test.Interfaces.IPerson GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Test.Interfaces.IPerson), -627797884, primaryKey, grainClassNamePrefix));
                        }

            public static Test.Interfaces.IPerson Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return PersonReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("Test.Interfaces.Test.Interfaces.IPerson")]
        internal class PersonReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, Test.Interfaces.IPerson
        {
            

            public static Test.Interfaces.IPerson Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (Test.Interfaces.IPerson) global::Orleans.Runtime.GrainReference.CastInternal(typeof(Test.Interfaces.IPerson), (global::Orleans.Runtime.GrainReference gr) => { return new PersonReference(gr);}, grainRef, -627797884);
            }
            
            protected internal PersonReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal PersonReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -627797884;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "Test.Interfaces.Test.Interfaces.IPerson";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                PersonReference input = ((PersonReference)(original));
                return ((PersonReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                PersonReference input = ((PersonReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return PersonReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return PersonMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task Test.Interfaces.IPerson.Register(Test.Interfaces.PersonalAttributes person)
            {

                return base.InvokeMethodAsync<object>(-1544510960, new object[] {person} );
            }
            
            System.Threading.Tasks.Task Test.Interfaces.IPerson.Marry(Test.Interfaces.IPerson spouse)
            {

                return base.InvokeMethodAsync<object>(1859357851, new object[] {spouse is global::Orleans.Grain ? Test.Interfaces.PersonFactory.Cast(spouse.AsReference()) : spouse} );
            }
            
            System.Threading.Tasks.Task<string> Test.Interfaces.IPerson.GetFirstName()
            {

                return base.InvokeMethodAsync<System.String>(513673718, new object[] {} );
            }
            
            System.Threading.Tasks.Task<string> Test.Interfaces.IPerson.GetLastName()
            {

                return base.InvokeMethodAsync<System.String>(160660420, new object[] {} );
            }
            
            System.Threading.Tasks.Task<Test.Interfaces.GenderType> Test.Interfaces.IPerson.GetGender()
            {

                return base.InvokeMethodAsync<Test.Interfaces.GenderType>(-1388702422, new object[] {} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("Test.Interfaces.Test.Interfaces.IPerson", -627797884)]
    internal class PersonMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -627797884;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -627797884:  // IPerson
                        switch (methodId)
                        {
                            case -1544510960: 
                                return ((IPerson)grain).Register((PersonalAttributes)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 1859357851: 
                                return ((IPerson)grain).Marry((IPerson)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 513673718: 
                                return ((IPerson)grain).GetFirstName().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 160660420: 
                                return ((IPerson)grain).GetLastName().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1388702422: 
                                return ((IPerson)grain).GetGender().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -627797884:  // IPerson
                    switch (methodId)
                    {
                        case -1544510960:
                            return "Register";
                    case 1859357851:
                            return "Marry";
                    case 513673718:
                            return "GetFirstName";
                    case 160660420:
                            return "GetLastName";
                    case -1388702422:
                            return "GetGender";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Test_Interfaces_PersonalAttributesSerialization
    {
        
        static Test_Interfaces_PersonalAttributesSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Test.Interfaces.PersonalAttributes input = ((Test.Interfaces.PersonalAttributes)(original));
            Test.Interfaces.PersonalAttributes result = new Test.Interfaces.PersonalAttributes();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.FirstName = input.FirstName;
            result.Gender = input.Gender;
            result.LastName = input.LastName;
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Test.Interfaces.PersonalAttributes input = ((Test.Interfaces.PersonalAttributes)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.FirstName, stream, typeof(String));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Gender, stream, typeof(GenderType));
            Orleans.Serialization.SerializationManager.SerializeInner(input.LastName, stream, typeof(String));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Test.Interfaces.PersonalAttributes result = new Test.Interfaces.PersonalAttributes();
            result.FirstName = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            result.Gender = ((GenderType)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(GenderType), stream)));
            result.LastName = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Test.Interfaces.PersonalAttributes), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
