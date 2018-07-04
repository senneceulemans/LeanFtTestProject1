<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Application Model</name>
  <className>ApplicationModel</className>
  <objects>
    <object technology="Web" type="Page">
      <name>MainMenu</name>
      <codeName>MainMenu</codeName>
      <description />
      <identification />
      <children>
        <object technology="Web" type="EditField">
          <name>SearchField</name>
          <codeName>SearchField</codeName>
          <description />
          <identification>
            <properties>
              <property name="Id" type="string">searchfor</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="Button">
          <name></name>
          <codeName>btn_Search</codeName>
          <description />
          <identification>
            <properties>
              <property name="Attributes" type="dictionary">
                <property name="data-test" type="string">search-button</property>
              </property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
    <object technology="Web" type="Page">
      <name>SearchResultsPage</name>
      <codeName>SearchResultsPage</codeName>
      <description />
      <identification />
    </object>
  </objects>
</applicationModel>