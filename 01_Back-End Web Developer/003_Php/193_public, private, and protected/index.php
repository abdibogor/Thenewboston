<?php

class BankAccount {
	public $balance = 10.5;

	public function DisplayBalance() {
		return 'Balance: '.$this->balance;
	}

  public function Withdraw($amount) {
  	if (($this->balance)<$amount) {
  		echo 'Not enough money.';
  	 } else {
  	     $this->balance = $this->balance - $amount; 
  		  	  }  	  
       }

    }

// new instance of class
$alex = new BankAccount;
$billy = new BankAccount;

$alex->Deposit(100);
$billy->Deposit(15);

// withdrawing 5
$alex->Withdraw(98);
$billy->withdraw(2.50);

// displaying balance
echo $alex->DisplayBalance().'<br>';	
echo $billy->DisplayBalance();
?>