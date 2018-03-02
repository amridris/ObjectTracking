#pragma once
#include "ManagedObject.h"
#include "../ObjectTrackingDB.Cpp/Core.h"

using namespace System;
namespace CLI
{
	public ref class StoreItem : public ManagedObject<ObjectTrackingDB::StoreItem>{
	public:
		StoreItem(int itemNumber);
		void auto_set_number();
		property int itemNumber {
		public:
			int get()
			{
				return m_Instance->getItemNumber();
			}
			void set(int itemNumber)
			{
				m_Instance->setItemNumber(itemNumber);
			}
		}
	};
}