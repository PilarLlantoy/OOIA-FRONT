﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ooiasoft.EspecialidadWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", ConfigurationName="EspecialidadWS.EspecialidadWS")]
    public interface EspecialidadWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/listarEspecialidadesPorNombre" +
            "Request", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/listarEspecialidadesPorNombre" +
            "Response")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreResponse listarEspecialidadesPorNombre(ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/listarEspecialidadesPorNombre" +
            "Request", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/listarEspecialidadesPorNombre" +
            "Response")]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreResponse> listarEspecialidadesPorNombreAsync(ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.EspecialidadWS.eliminarEspecialidadResponse eliminarEspecialidad(ooiasoft.EspecialidadWS.eliminarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadResponse")]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.eliminarEspecialidadResponse> eliminarEspecialidadAsync(ooiasoft.EspecialidadWS.eliminarEspecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.EspecialidadWS.insertarEspecialidadResponse insertarEspecialidad(ooiasoft.EspecialidadWS.insertarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.insertarEspecialidadResponse> insertarEspecialidadAsync(ooiasoft.EspecialidadWS.insertarEspecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/modificarEspecialidadRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/modificarEspecialidadResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.EspecialidadWS.modificarEspecialidadResponse modificarEspecialidad(ooiasoft.EspecialidadWS.modificarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/modificarEspecialidadRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/EspecialidadWS/modificarEspecialidadResponse" +
            "")]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.modificarEspecialidadResponse> modificarEspecialidadAsync(ooiasoft.EspecialidadWS.modificarEspecialidadRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/")]
    public partial class especialidad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private bool estadoField;
        
        private int idEspecialidadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idEspecialidad {
            get {
                return this.idEspecialidadField;
            }
            set {
                this.idEspecialidadField = value;
                this.RaisePropertyChanged("idEspecialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEspecialidadesPorNombre", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEspecialidadesPorNombreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        public listarEspecialidadesPorNombreRequest() {
        }
        
        public listarEspecialidadesPorNombreRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEspecialidadesPorNombreResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEspecialidadesPorNombreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ooiasoft.EspecialidadWS.especialidad[] @return;
        
        public listarEspecialidadesPorNombreResponse() {
        }
        
        public listarEspecialidadesPorNombreResponse(ooiasoft.EspecialidadWS.especialidad[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEspecialidad", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEspecialidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idEspecialidad;
        
        public eliminarEspecialidadRequest() {
        }
        
        public eliminarEspecialidadRequest(int idEspecialidad) {
            this.idEspecialidad = idEspecialidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEspecialidadResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarEspecialidadResponse() {
        }
        
        public eliminarEspecialidadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEspecialidad", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEspecialidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ooiasoft.EspecialidadWS.especialidad especialidad;
        
        public insertarEspecialidadRequest() {
        }
        
        public insertarEspecialidadRequest(ooiasoft.EspecialidadWS.especialidad especialidad) {
            this.especialidad = especialidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEspecialidadResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarEspecialidadResponse() {
        }
        
        public insertarEspecialidadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidad", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ooiasoft.EspecialidadWS.especialidad especialidad;
        
        public modificarEspecialidadRequest() {
        }
        
        public modificarEspecialidadRequest(ooiasoft.EspecialidadWS.especialidad especialidad) {
            this.especialidad = especialidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidadResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarEspecialidadResponse() {
        }
        
        public modificarEspecialidadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EspecialidadWSChannel : ooiasoft.EspecialidadWS.EspecialidadWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EspecialidadWSClient : System.ServiceModel.ClientBase<ooiasoft.EspecialidadWS.EspecialidadWS>, ooiasoft.EspecialidadWS.EspecialidadWS {
        
        public EspecialidadWSClient() {
        }
        
        public EspecialidadWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EspecialidadWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EspecialidadWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EspecialidadWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreResponse ooiasoft.EspecialidadWS.EspecialidadWS.listarEspecialidadesPorNombre(ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest request) {
            return base.Channel.listarEspecialidadesPorNombre(request);
        }
        
        public ooiasoft.EspecialidadWS.especialidad[] listarEspecialidadesPorNombre(string nombre) {
            ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest inValue = new ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest();
            inValue.nombre = nombre;
            ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreResponse retVal = ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).listarEspecialidadesPorNombre(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreResponse> ooiasoft.EspecialidadWS.EspecialidadWS.listarEspecialidadesPorNombreAsync(ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest request) {
            return base.Channel.listarEspecialidadesPorNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreResponse> listarEspecialidadesPorNombreAsync(string nombre) {
            ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest inValue = new ooiasoft.EspecialidadWS.listarEspecialidadesPorNombreRequest();
            inValue.nombre = nombre;
            return ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).listarEspecialidadesPorNombreAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.EspecialidadWS.eliminarEspecialidadResponse ooiasoft.EspecialidadWS.EspecialidadWS.eliminarEspecialidad(ooiasoft.EspecialidadWS.eliminarEspecialidadRequest request) {
            return base.Channel.eliminarEspecialidad(request);
        }
        
        public int eliminarEspecialidad(int idEspecialidad) {
            ooiasoft.EspecialidadWS.eliminarEspecialidadRequest inValue = new ooiasoft.EspecialidadWS.eliminarEspecialidadRequest();
            inValue.idEspecialidad = idEspecialidad;
            ooiasoft.EspecialidadWS.eliminarEspecialidadResponse retVal = ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).eliminarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.eliminarEspecialidadResponse> ooiasoft.EspecialidadWS.EspecialidadWS.eliminarEspecialidadAsync(ooiasoft.EspecialidadWS.eliminarEspecialidadRequest request) {
            return base.Channel.eliminarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.eliminarEspecialidadResponse> eliminarEspecialidadAsync(int idEspecialidad) {
            ooiasoft.EspecialidadWS.eliminarEspecialidadRequest inValue = new ooiasoft.EspecialidadWS.eliminarEspecialidadRequest();
            inValue.idEspecialidad = idEspecialidad;
            return ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).eliminarEspecialidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.EspecialidadWS.insertarEspecialidadResponse ooiasoft.EspecialidadWS.EspecialidadWS.insertarEspecialidad(ooiasoft.EspecialidadWS.insertarEspecialidadRequest request) {
            return base.Channel.insertarEspecialidad(request);
        }
        
        public int insertarEspecialidad(ooiasoft.EspecialidadWS.especialidad especialidad) {
            ooiasoft.EspecialidadWS.insertarEspecialidadRequest inValue = new ooiasoft.EspecialidadWS.insertarEspecialidadRequest();
            inValue.especialidad = especialidad;
            ooiasoft.EspecialidadWS.insertarEspecialidadResponse retVal = ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).insertarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.insertarEspecialidadResponse> ooiasoft.EspecialidadWS.EspecialidadWS.insertarEspecialidadAsync(ooiasoft.EspecialidadWS.insertarEspecialidadRequest request) {
            return base.Channel.insertarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.insertarEspecialidadResponse> insertarEspecialidadAsync(ooiasoft.EspecialidadWS.especialidad especialidad) {
            ooiasoft.EspecialidadWS.insertarEspecialidadRequest inValue = new ooiasoft.EspecialidadWS.insertarEspecialidadRequest();
            inValue.especialidad = especialidad;
            return ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).insertarEspecialidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.EspecialidadWS.modificarEspecialidadResponse ooiasoft.EspecialidadWS.EspecialidadWS.modificarEspecialidad(ooiasoft.EspecialidadWS.modificarEspecialidadRequest request) {
            return base.Channel.modificarEspecialidad(request);
        }
        
        public int modificarEspecialidad(ooiasoft.EspecialidadWS.especialidad especialidad) {
            ooiasoft.EspecialidadWS.modificarEspecialidadRequest inValue = new ooiasoft.EspecialidadWS.modificarEspecialidadRequest();
            inValue.especialidad = especialidad;
            ooiasoft.EspecialidadWS.modificarEspecialidadResponse retVal = ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).modificarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.modificarEspecialidadResponse> ooiasoft.EspecialidadWS.EspecialidadWS.modificarEspecialidadAsync(ooiasoft.EspecialidadWS.modificarEspecialidadRequest request) {
            return base.Channel.modificarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.EspecialidadWS.modificarEspecialidadResponse> modificarEspecialidadAsync(ooiasoft.EspecialidadWS.especialidad especialidad) {
            ooiasoft.EspecialidadWS.modificarEspecialidadRequest inValue = new ooiasoft.EspecialidadWS.modificarEspecialidadRequest();
            inValue.especialidad = especialidad;
            return ((ooiasoft.EspecialidadWS.EspecialidadWS)(this)).modificarEspecialidadAsync(inValue);
        }
    }
}
