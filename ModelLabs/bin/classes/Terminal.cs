//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    
    
    /// An electrical connection point to a piece of conducting equipment. Terminals are connected at physical connection points called connectivity nodes.
    public class Terminal : IdentifiedObject {
        
        /// The conducting equipment of the terminal.  Conducting equipment have  terminals that may be connected to other conducting equipment terminals via connectivity nodes or topological nodes.
        private ConductingEquipment cim_ConductingEquipment;
        
        private const bool isConductingEquipmentMandatory = true;
        
        private const string _ConductingEquipmentPrefix = "cim";
        
        /// The connected status is related to a bus-branch model and the topological node to terminal relation.  True implies the terminal is connected to the related topological node and false implies it is not. 
        ///In a bus-branch model, the connected status is used to tell if equipment is disconnected without having to change the connectivity described by the topological node to terminal relation. A valid case is that conducting equipment can be connected in one end and open in the other. In particular for an AC line segment, where the reactive line charging can be significant, this is a relevant case.
        private System.Boolean? cim_connected;
        
        private const bool isConnectedMandatory = false;
        
        private const string _connectedPrefix = "cim";
        
        /// The connectivity node to which this terminal connects with zero impedance.
        private ConnectivityNode cim_ConnectivityNode;
        
        private const bool isConnectivityNodeMandatory = false;
        
        private const string _ConnectivityNodePrefix = "cim";
        
        /// Represents the normal network phasing condition.
        private PhaseCode? cim_phases;
        
        private const bool isPhasesMandatory = false;
        
        private const string _phasesPrefix = "cim";
        
        /// The orientation of the terminal connections for a multiple terminal conducting equipment.  The sequence numbering starts with 1 and additional terminals should follow in increasing order.   The first terminal is the "starting point" for a two terminal branch.
        private System.Int32? cim_sequenceNumber;
        
        private const bool isSequenceNumberMandatory = false;
        
        private const string _sequenceNumberPrefix = "cim";
        
        public virtual ConductingEquipment ConductingEquipment {
            get {
                return this.cim_ConductingEquipment;
            }
            set {
                this.cim_ConductingEquipment = value;
            }
        }
        
        public virtual bool ConductingEquipmentHasValue {
            get {
                return this.cim_ConductingEquipment != null;
            }
        }
        
        public static bool IsConductingEquipmentMandatory {
            get {
                return isConductingEquipmentMandatory;
            }
        }
        
        public static string ConductingEquipmentPrefix {
            get {
                return _ConductingEquipmentPrefix;
            }
        }
        
        public virtual bool Connected {
            get {
                return this.cim_connected.GetValueOrDefault();
            }
            set {
                this.cim_connected = value;
            }
        }
        
        public virtual bool ConnectedHasValue {
            get {
                return this.cim_connected != null;
            }
        }
        
        public static bool IsConnectedMandatory {
            get {
                return isConnectedMandatory;
            }
        }
        
        public static string ConnectedPrefix {
            get {
                return _connectedPrefix;
            }
        }
        
        public virtual ConnectivityNode ConnectivityNode {
            get {
                return this.cim_ConnectivityNode;
            }
            set {
                this.cim_ConnectivityNode = value;
            }
        }
        
        public virtual bool ConnectivityNodeHasValue {
            get {
                return this.cim_ConnectivityNode != null;
            }
        }
        
        public static bool IsConnectivityNodeMandatory {
            get {
                return isConnectivityNodeMandatory;
            }
        }
        
        public static string ConnectivityNodePrefix {
            get {
                return _ConnectivityNodePrefix;
            }
        }
        
        public virtual PhaseCode Phases {
            get {
                return this.cim_phases.GetValueOrDefault();
            }
            set {
                this.cim_phases = value;
            }
        }
        
        public virtual bool PhasesHasValue {
            get {
                return this.cim_phases != null;
            }
        }
        
        public static bool IsPhasesMandatory {
            get {
                return isPhasesMandatory;
            }
        }
        
        public static string PhasesPrefix {
            get {
                return _phasesPrefix;
            }
        }
        
        public virtual int SequenceNumber {
            get {
                return this.cim_sequenceNumber.GetValueOrDefault();
            }
            set {
                this.cim_sequenceNumber = value;
            }
        }
        
        public virtual bool SequenceNumberHasValue {
            get {
                return this.cim_sequenceNumber != null;
            }
        }
        
        public static bool IsSequenceNumberMandatory {
            get {
                return isSequenceNumberMandatory;
            }
        }
        
        public static string SequenceNumberPrefix {
            get {
                return _sequenceNumberPrefix;
            }
        }
    }
}
