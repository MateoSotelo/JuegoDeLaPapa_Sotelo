﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";
	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}
	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
	public int DadosRestantes { get; set; }
    [DataMember]
	public List<int> Numeros { get; set; }
    [DataMember]
    public bool ContinuarJuego 
    { 
        get { return ContinuarJuego; } 

        set {
            if (DadosRestantes > 1)
            {
                ContinuarJuego = true;
            }
            else
            {
                ContinuarJuego = false;
            } 
        } 
    }

}
