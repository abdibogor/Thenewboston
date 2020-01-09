from collections import Counter 

text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. "\
	   "Stet clita kasd gubergren consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. "\
	   "Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. "\
	   "consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. "\
	   "Solution to that problem."

words = text.split()
#print(words)

counter = Counter(words)
top_three = counter.most_common(3)
print(top_three)