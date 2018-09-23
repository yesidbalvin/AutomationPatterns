using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rules.Data;
using Rules.Rules;

namespace Rules
{
    /// <summary>
    /// Definition
    //Separate the logic of each individual rule and its effects into its own class. 
    //Separate the selection and processing of rules into a separate Evaluator class.
    //Separate individual rules from rules processing logic.
    //Allow new rules to be added without the need for changes in the rest of the system.
    /// </summary>
    [TestClass]
    public class RulesTest
    {
        [TestMethod]
        public void Rules_Test()
        {
            var purchaseTestInput = new PurchaseTestInput()
            {
                IsWiretransfer = false,
                IsPromotionalPurchase = false,
                TotalPrice = 100,
                CreditCardNumber = "378734493671000"
            };

            var rulesEvaluator = new RulesEvaluator();

            rulesEvaluator.Eval(new PromotionalPurchaseRule(purchaseTestInput, () => PerformUiAssert()));
            rulesEvaluator.Eval(new CreditCardChargeRule(purchaseTestInput, 20, () => PerformUiAssert()));
            rulesEvaluator.OtherwiseEval(new PromotionalPurchaseRule(purchaseTestInput, () => PerformUiAssert()));
            rulesEvaluator.OtherwiseEval(new CreditCardChargeRule<CreditCardChargeRuleRuleResult>(purchaseTestInput, 30));
            rulesEvaluator.OtherwiseEval(new CreditCardChargeRule<CreditCardChargeRuleAssertResult>(purchaseTestInput, 40));
            rulesEvaluator.OtherwiseEval(new CreditCardChargeRule(purchaseTestInput, 50, () => PerformUiAssert()));
            rulesEvaluator.OtherwiseDo(() => Debug.WriteLine("Perform other UI actions"));

            rulesEvaluator.EvaluateRulesChains();
        }


        [TestMethod]
        public void NoRules_Test()
        {
            var purchaseTestInput = new PurchaseTestInput()
            {
                IsWiretransfer = false,
                IsPromotionalPurchase = false,
                TotalPrice = 100,
                CreditCardNumber = "378734493671000"
            };
            if (string.IsNullOrEmpty(purchaseTestInput.CreditCardNumber) &&
                !purchaseTestInput.IsWiretransfer &&
                purchaseTestInput.IsPromotionalPurchase &&
                purchaseTestInput.TotalPrice == 0)
            {
                PerformUiAssert("Assert volume discount promotion amount. + additional UI actions");
            }
            if (!string.IsNullOrEmpty(purchaseTestInput.CreditCardNumber) &&
                !purchaseTestInput.IsWiretransfer &&
                !purchaseTestInput.IsPromotionalPurchase &&
                purchaseTestInput.TotalPrice > 20)
            {
                PerformUiAssert("Assert that total amount label is over 20$ + additional UI actions");
            }
            else if (!string.IsNullOrEmpty(purchaseTestInput.CreditCardNumber) &&
                     !purchaseTestInput.IsWiretransfer &&
                     !purchaseTestInput.IsPromotionalPurchase &&
                     purchaseTestInput.TotalPrice > 30)
            {
                Console.WriteLine("Assert that total amount label is over 30$ + additional UI actions");
            }
            else if (!string.IsNullOrEmpty(purchaseTestInput.CreditCardNumber) &&
                     !purchaseTestInput.IsWiretransfer &&
                     !purchaseTestInput.IsPromotionalPurchase &&
                     purchaseTestInput.TotalPrice > 40)
            {
                Console.WriteLine("Assert that total amount label is over 40$ + additional UI actions");
            }
            else if (!string.IsNullOrEmpty(purchaseTestInput.CreditCardNumber) &&
                     !purchaseTestInput.IsWiretransfer &&
                     !purchaseTestInput.IsPromotionalPurchase &&
                     purchaseTestInput.TotalPrice > 50)
            {
                PerformUiAssert("Assert that total amount label is over 50$ + additional UI actions");
            }
            else
            {
                Debug.WriteLine("Perform other UI actions");
            }
        }


        private void PerformUiAssert(string text = "Perform other UI actions")
        {
            Debug.WriteLine(text);
        }
    }
}
