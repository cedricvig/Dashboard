<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="e0bc51a7-f570-4629-b265-e67d1adfd9f3" namespace="ND.MonitorDasboard.Web.Config" xmlSchemaNamespace="urn:ND.MonitorDasboard.Web.Config" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationElement name="Monitor">
      <attributeProperties>
        <attributeProperty name="ApplicationCode" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="applicationCode" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="ApplicationName" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="applicationName" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="RemotePort" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="remotePort" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Int32" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="Node">
      <attributeProperties>
        <attributeProperty name="MachineName" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="machineName" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="LifeResult" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="lifeResult" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Int32" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="Cluster">
      <attributeProperties>
        <attributeProperty name="Code" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="code" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Label" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="label" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="Nodes" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="nodes" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Nodes" />
          </type>
        </elementProperty>
        <elementProperty name="Environment" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="environment" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Environment" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElementCollection name="Monitors" xmlItemName="monitor" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Monitor" />
      </itemType>
    </configurationElementCollection>
    <configurationElementCollection name="Nodes" xmlItemName="node" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Node" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="Environment">
      <attributeProperties>
        <attributeProperty name="Code" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="code" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Label" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="label" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="Clusters" xmlItemName="cluster" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Cluster" />
      </itemType>
    </configurationElementCollection>
    <configurationSection name="MonitorDashoardConfiguration" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="monitorDashoardConfiguration">
      <elementProperties>
        <elementProperty name="Clusters" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="clusters" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Clusters" />
          </type>
        </elementProperty>
        <elementProperty name="Monitors" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="monitors" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/e0bc51a7-f570-4629-b265-e67d1adfd9f3/Monitors" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>