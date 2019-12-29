<?php
class Example {

	public function__construct($something) {
		$this->SaySomething($something);
	}

	public function SaySomething($something) {
		echo '$Something';
	}

}

$example = new Example('Some text');
//$example->Saysomething();

?>