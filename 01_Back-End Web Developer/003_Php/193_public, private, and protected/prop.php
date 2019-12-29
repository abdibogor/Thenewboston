<?php
	  
	  class BankAccount {
	  	 /*protect var $_balanceOfAccount = 3500; */
	  	 //var $_balance = 3500;
	  	 private $balance = 3500;

	  	 public function DisplayBalance() {
	  	 	return $this->balance;
	  	 }
	  }	

	$alex = new BankAccount;
	//echo $alex->balance();
	//echo $alex->balanceOfAccount;
	 echo $alex->DisplayBalance();
	 echo $alex->balance;
?>