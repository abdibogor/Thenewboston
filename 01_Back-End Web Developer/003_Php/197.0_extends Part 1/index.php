<?php

class BankAccount{
    public $balance = 10.5;

    public function DisplayBalance(){
        if(($this->balance)<0){
            return false;
        }else{
            return 'Balance: '.$this->balance.'</br>';
        }
    }

    public function Withdraw($amount){

        if (($this->balance)<$amount){
        echo 'Not Enough Founds: '.'</br>';
        }else{
        $this->balance=$this->balance - $amount;
        }
    }

    public function Transaction($trans){
        $this->balance=$this->balance + $trans;
    }
}


$alex = new BankAccount;
$alex->Withdraw(12);
echo $alex->DisplayBalance();

$abdul = new BankAccount;
$abdul->Transaction(10);
echo $abdul->DisplayBalance();

?>