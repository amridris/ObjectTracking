#include "ObjectTrackingForm.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]
void Main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	ObjectTrackingCppFormUI::ObjectTrackingForm form;
	Application::Run(%form);
}