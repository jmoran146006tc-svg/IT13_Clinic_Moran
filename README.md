
PSEUDOCODE:
```
DECLARE queueCounter AS INTEGER = 1

WHEN CLINIC_QUEUE is clicked
BEGIN CLINIC_QUEUE
    INPUT PatientName
    INPUT Age
    INPUT ReasonForVisit
    INPUT PatientType

    IF PatientName is empty OR Age is empty OR PatientType has no selection THEN
        DISPLAY "Please fill out all fields."
        RETURN
    ENDIF

    IF Age is not a valid whole number OR Age < 0 OR Age > 120 THEN
        DISPLAY "Please enter a valid age."
        RETURN
    ENDIF

    DECLARE queueString AS STRING
    SET queueString = "Q" + FORMAT(queueCounter, "000")

    DECLARE priorityText AS STRING
    DECLARE patientType AS STRING
    SET patientType = PatientType.SelectedItem

    SWITCH patientType
        CASE "Emergency":
            SET priorityText = "EMERGENCY"
        CASE "Senior":
            SET priorityText = "SENIOR PRIORITY"
        CASE "Pregnant":
            SET priorityText = "PRIORITY"
        CASE "Regular":
            SET priorityText = "REGULAR"
        DEFAULT:
            SET priorityText = "REGULAR"
    END SWITCH

    DISPLAY queueString, patientType, priorityText
    SET queueCounter = queueCounter + 1
END

WHEN CLEAR is clicked
BEGIN CLEAR
    SET PatientName.Text = ""
    SET Age.Text = ""
    SET ReasonForVisit.SelectedIndex = -1
    SET PatientType.SelectedIndex = -1
END
```

FLOWCHART:
<img width="593" height="1632" alt="FLOW drawio" src="https://github.com/user-attachments/assets/ba53dfa7-8183-42b1-932d-b9accc7a6be8" />


TEST CASE TABLE:
| No. | Test Case | Expected Result | Actual Result | Passed/Failed |
|-----|-----------|------------------|-----------------|----------------|
| 1 | Regular patient | Q001 / REGULAR | Q001 / REGULAR | Passed |
| 2 | Senior patient | Q002 / SENIOR PRIORITY | Q002 / SENIOR PRIORITY | Passed |
| 3 | Pregnant patient | Q003 / PRIORITY | Q003 / PRIORITY | Passed |
| 4 | Emergency patient | Q004 / EMERGENCY | Q004 / EMERGENCY | Passed |
| 5 | Another Regular patient | Q005 / REGULAR | Q005 / REGULAR | Passed |
| 6 | Click CLEAR | Fields and output are cleared | Fields and output are cleared | Passed |


COMPLETED INTERFACE:
<img width="569" height="407" alt="image" src="https://github.com/user-attachments/assets/a4373373-a0ce-45b7-909b-339ce56424d0" />


SUCCESSFUL RESULT:
<img width="579" height="406" alt="image" src="https://github.com/user-attachments/assets/89207481-c68f-4ac5-93ba-2a8548f5b4a2" />


