#pragma once
#include "ObjectTrackingDB.h"

using namespace ObjectTrackingDB;

namespace ObjectTrackingCppFormUI {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for ObjectTrackingForm
	/// </summary>
	public ref class ObjectTrackingForm : public System::Windows::Forms::Form
	{
	public:
		ObjectTrackingForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~ObjectTrackingForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btnTestCreateStoreItem;
	private: System::Windows::Forms::Label^  lblDatabase;
	private: System::Windows::Forms::Label^  lblTestStoreItemValue;

	protected:

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->btnTestCreateStoreItem = (gcnew System::Windows::Forms::Button());
			this->lblDatabase = (gcnew System::Windows::Forms::Label());
			this->lblTestStoreItemValue = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// btnTestCreateStoreItem
			// 
			this->btnTestCreateStoreItem->Location = System::Drawing::Point(328, 125);
			this->btnTestCreateStoreItem->Name = L"btnTestCreateStoreItem";
			this->btnTestCreateStoreItem->Size = System::Drawing::Size(131, 51);
			this->btnTestCreateStoreItem->TabIndex = 0;
			this->btnTestCreateStoreItem->Text = L"Test Create Store Item";
			this->btnTestCreateStoreItem->UseVisualStyleBackColor = true;
			this->btnTestCreateStoreItem->Click += gcnew System::EventHandler(this, &ObjectTrackingForm::btnTestCreateStoreItem_Click);
			// 
			// lblDatabase
			// 
			this->lblDatabase->AutoSize = true;
			this->lblDatabase->Location = System::Drawing::Point(328, 34);
			this->lblDatabase->Name = L"lblDatabase";
			this->lblDatabase->Size = System::Drawing::Size(79, 20);
			this->lblDatabase->TabIndex = 1;
			this->lblDatabase->Text = L"Database";
			// 
			// lblTestStoreItemValue
			// 
			this->lblTestStoreItemValue->AutoSize = true;
			this->lblTestStoreItemValue->Location = System::Drawing::Point(328, 183);
			this->lblTestStoreItemValue->Name = L"lblTestStoreItemValue";
			this->lblTestStoreItemValue->Size = System::Drawing::Size(46, 20);
			this->lblTestStoreItemValue->TabIndex = 2;
			this->lblTestStoreItemValue->Text = L"value";
			// 
			// ObjectTrackingForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 20);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(712, 574);
			this->Controls->Add(this->lblTestStoreItemValue);
			this->Controls->Add(this->lblDatabase);
			this->Controls->Add(this->btnTestCreateStoreItem);
			this->Name = L"ObjectTrackingForm";
			this->Text = L"ObjectTrackingForm";
			this->Load += gcnew System::EventHandler(this, &ObjectTrackingForm::ObjectTrackingForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void ObjectTrackingForm_Load(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void btnTestCreateStoreItem_Click(System::Object^  sender, System::EventArgs^  e) {
	}
			 int value;
			 StoreItem* test_item = new StoreItem(20);
	};
}
