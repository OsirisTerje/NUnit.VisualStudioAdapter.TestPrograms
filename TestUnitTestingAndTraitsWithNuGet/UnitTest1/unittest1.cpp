#include "stdafx.h"
#include "CppUnitTest.h"
// #include "../Win32Project1/Mathematics.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTestNativeCPP
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		BEGIN_TEST_METHOD_ATTRIBUTE(TestMethodCPPNAT1)
			TEST_OWNER(L"Terje")
			TEST_PRIORITY(2)
			TEST_METHOD_ATTRIBUTE(L"TestCategory",L"Production")
		END_TEST_METHOD_ATTRIBUTE()

		TEST_METHOD(TestMethodCPPNAT1)
		{
			Assert::IsTrue(true);
		}

		/*BEGIN_TEST_METHOD_ATTRIBUTE(TestMethodCPPNAT2)
			TEST_OWNER(L"Terje")
			TEST_PRIORITY(2)
			TEST_METHOD_ATTRIBUTE(L"Category",L"CI")
			TEST_IGNORE()
		END_TEST_METHOD_ATTRIBUTE()

		TEST_METHOD(TestMethodCPPNAT2)
		{
			Assert::IsTrue(true);
		}*/

	};
		}

namespace UnitTestNativeCPP2
{	
	

	TEST_CLASS(UnitTest2)
	{

	public:
		
		BEGIN_TEST_CLASS_ATTRIBUTE()
			TEST_CLASS_ATTRIBUTE(L"TestCategory",L"CI")
		END_TEST_CLASS_ATTRIBUTE()

		
		TEST_METHOD(TestMethodCPPNAT21)
		{
			Assert::IsTrue(true);
		}

		TEST_METHOD(TestMethodCPPNAT22)
		{
			Assert::IsTrue(true);
		}
	};

	/*TEST_CLASS(MathematicsTest)
	{
	public:
		BEGIN_TEST_METHOD_ATTRIBUTE(TestMathAddNAT)
			TEST_METHOD_ATTRIBUTE(L"Category",L"CI")
			TEST_PRIORITY(1)
		END_TEST_METHOD_ATTRIBUTE()
			
			TEST_METHOD(TestMathAddNAT)
		{
			auto math = new Mathematics();
			auto res = math->Add(2,3);
			Assert::IsTrue(res==5);
		};
	};*/
}